#20532: Developing Microsoft Azure Solutions

## What are we doing?
* To support course [20532B Developing Microsoft Azure Solutions](https://www.microsoft.com/learning/en-us/course.aspx?ID=20532B), we will need to make frequent updates to the course content to keep it current with the Azure services used in the course.  We are publishing the lab instructions and lab files on GitHub to allow for open contributions between the course authors and MCTs to keep the content current with changes in the Azure platform.
* We hope that this brings a sense of collaboration to the labs like we've never had before - when Azure changes and you find it first during a live delivery, go ahead and make an enhancement right in the lab source.  Help your fellow MCTs.

## Where will the files be?
* The files are available in a GitHub repo at https://github.com/MicrosoftLearning/20532-DevelopingMicrosoftAzureSolutions

## How should I use these files relative to the released MOC files?
* We'll do new builds weekly of portable versions of the MD source so you can always have a build of the latest ready to share with your students.
* These open files are designed to be used in conjunction with the student handbook, but are in GitHub as a central repository so MCTs and course authors can have a shared source for the latest files.
* It will be recommended that for every delivery of 20532B, trainers check GitHub for any changes that may have been made to support the latest Azure services, and get the latest files for their delivery.

## How do I contribute?
* Any MCT can submit a pull request to the code or content in the GitHub repro, Microsoft and the course author will triage and include content and lab code changes as needed.
* You can submit bugs, changes, improvement and ideas.  Find a new Azure feature before we have?  Submit a new demo!

## What about changes to the student handbook?
* The student handbook will get updated on a regular basis through normal MOC release channels as needed basis.  

## Notes

### ARM Template
This repo includes an ARM template (located in the [ARM](/ARM) folder) that can be deployed in-lieu of doing the second lab. This is useful for scenarios where you need to catch up a student after they deployment has failed.

<a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FMicrosoftLearning%2F20532-DevelopingMicrosoftAzureSolutions%2Fc-release%2FARM%2Flabvm_template.deploy.json" target="_blank">
    <img src="http://azuredeploy.net/deploybutton.png"/>
</a>
<a href="http://armviz.io/#/?load=https:%2F%2Fraw.githubusercontent.com%2FMicrosoftLearning%2F20532-DevelopingMicrosoftAzureSolutions%2Fc-release%2FARM%2Flabvm_template.deploy.json" target="_blank">
    <img src="http://armviz.io/visualizebutton.png"/>
</a>
