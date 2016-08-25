var marked = require('marked');
var fs = require('fs');
var path = require('path');
var cp = require('child_process');
var pandoc = require('pandoc-bin');
var readFiles = require('fs-readdir-recursive');
var del = require('delete');
var archiver = require('archiver');
var copy = require('ncp');
const readline = require('readline');

marked.setOptions({
    renderer: new marked.Renderer(),
    gfm: true,
    tables: true,
    breaks: false,
    pedantic: false,
    sanitize: true,
    smartLists: true,
    smartypants: false
});

var filesInputDirectory = path.join(__dirname, "..\\Allfiles\\dotnet\\");
var docLabsInputDirectory = path.join(__dirname, "..\\Instructions\\Labs\\dotnet\\");
var docDemosInputDirectory = path.join(__dirname, "..\\Instructions\\Demos\\dotnet\\");
var outputDirectory = path.join(__dirname, "Temp\\");
var docsOutputDirectory = outputDirectory + "Instructions\\";
var filesOutputDirectory = outputDirectory + "AllFiles\\";
var markdownFileNameRegex = /Mod[0-9]{2}\\(.*).md/;
var filesOutputZip = "allfiles.zip"
var docsOutputZip = "lab_instructions.zip"

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question('Specify a version number (ex. 0.5.0): ', (answer) => {
    filesOutputZip = "allfiles-v" + answer + ".zip"
    docsOutputZip = "lab_instructions-v" + answer + ".zip"
    if (fs.existsSync(outputDirectory)) {
        del.sync([outputDirectory]);
    }
    fs.mkdirSync(outputDirectory);

    if (fs.existsSync(docsOutputDirectory)) {
        del.sync([docsOutputDirectory]);
    }
    fs.mkdirSync(docsOutputDirectory);
    createLabDemosZip(function() {
        createAllFilesZip(function() {
            cleanup();
        });
    });
    rl.close();
});

function createLabDemosZip(callback) {
    console.log('Generating File:', docsOutputZip);
    var labFiles = readFiles(docLabsInputDirectory);
    labFiles.forEach(function(fileName, index) {
        console.log("Lab File:\t" + fileName);
        buildDocx(path.join(docLabsInputDirectory, fileName), fileName.replace(markdownFileNameRegex, '$1'));
    });
    var labFiles = readFiles(docDemosInputDirectory);
    labFiles.forEach(function(fileName, index) {
        console.log("Demo File:\t" + fileName);
        buildDocx(path.join(docDemosInputDirectory, fileName), fileName.replace(markdownFileNameRegex, '$1'));
    });
    var labOutput = fs.createWriteStream(docsOutputZip);
    var labArchive = archiver.create('zip', {});
    labArchive.pipe(labOutput);
    labArchive.directory(docsOutputDirectory, false, { date: new Date() });
    labArchive.finalize();
    labOutput.on('close', function() {
        console.log('Lab & Demos Archive Created');
        callback();
    });
}

function createAllFilesZip(callback) {
    console.log('Generating File:', filesOutputZip);
    copy.ncp(filesInputDirectory, filesOutputDirectory, function(error) {
        var filesOutput = fs.createWriteStream(filesOutputZip);
        var filesArchive = archiver.create('zip', {});
        filesArchive.pipe(filesOutput);
        filesArchive.directory(filesOutputDirectory, false, { date: new Date() });
        filesArchive.finalize();
        filesOutput.on('close', function() {
            console.log('AllFiles Archive Created');
            callback();
        });
    });
}

function cleanup() {
    console.log('Cleaing Up Temporary Folders');
    del.sync([outputDirectory]);
}

function buildDocx(markdownPath, baseFileName) {
    var htmlFilePath = createHtmlFile(markdownPath, baseFileName + '.html');
    var docxFilePath = createDocxFile(htmlFilePath, baseFileName + '.docx');
    deleteHtmlFile(htmlFilePath);
    return docxFilePath;
}

function createHtmlFile(markdownPath, newFileName) {
    var markdownString = fs.readFileSync(markdownPath, 'utf8');
    var htmlString = marked(markdownString);
    var outPath = path.join(docsOutputDirectory, newFileName);
    fs.writeFileSync(outPath, htmlString);
    return outPath;
}

function deleteHtmlFile(htmlPath) {
    fs.unlinkSync(htmlPath);
}

function createDocxFile(htmlPath, newFileName) {
    var outPath = path.join(docsOutputDirectory, newFileName);
    cp.execFileSync(pandoc.path, [htmlPath, '--reference-docx=template.docx', '-o', outPath]);
}