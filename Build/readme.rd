# Building the course

It is **strongly** recommended that you use the released files for instructor-led or online deliveries. These steps exist to help you re-build the files manually.

## Prerequisites

* Node ([nodejs.org](http://nodejs.org))
  * Tested on version **4.4.5**
* NPM ([npmjs.com](http://npmjs.com))
  * Tested on version **3.9.5**

## Manual Builds
A Node build script is included that will build the course and output two zip files, one for the **AllFiles** and one for the **Lab Instructions**.  The script will initially prompt you for a version number and that version number is used in the name of the resulting zip files.  Both prerequisites must be installed prior to running the script.

To run the script, use the following commands at the **Build** directory of this repository:

  ```shell
  npm install
  ```

  ```shell
  npm run build
  ```
