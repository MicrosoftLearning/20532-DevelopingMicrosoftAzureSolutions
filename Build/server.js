var marked = require('marked');
var fs = require('fs');
var path = require('path');
var cp = require('child_process');
var pandoc = require('pandoc-bin');
var readFiles = require('fs-readdir-recursive');

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

var docLabsInputDirectory = path.join(__dirname, "..\\Instructions\\Labs\\dotnet\\");
var outputDirectory = path.join(__dirname, "Temp\\");
var docsOutputDirectory = outputDirectory + "Instructions\\";

console.log(docLabsInputDirectory);
var labFiles = readFiles(docLabsInputDirectory);
labFiles.forEach(function(file, index) {
    buildLabInstruction(path.join(docLabsInputDirectory, file));
});

function buildLabInstruction(markdownPath) {
    console.log(markdownPath);
}

function createHtmlFile() {

}

function createDocxFile() {

}