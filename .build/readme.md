# Build Instructions

## Manual Build on Your Local Machine

1. Clone the GitHub repository to an empty folder on your local machine:

    ```
    git clone https://github.com/MicrosoftLearning/20532-DevelopingMicrosoftAzureSolutions.git
    ```

1. Change your current directory to the ``.build`` directory:

    ```
    cd .build
    ```

1. Run ``npm install`` to install all required dependencies:

    ```
    npm install
    ```

1. Run ``node package.js`` to run the packaging script specifying version number and course identifier:

    ```
    node package.js --version 1.0.0 --course 20532D
    ```

## Docker Image

If you do not have Node or Git installed on your local machine, we have a Docker Hub image with the required versions of each tool located at: [seesharprun/content-generation-pandoc/](https://hub.docker.com/r/seesharprun/content-generation-pandoc/).

This Docker Hub image is used as part of a CI build running in CircleCI: [![CircleCI](https://circleci.com/gh/MicrosoftLearning/20532-DevelopingMicrosoftAzureSolutions/tree/master.svg?style=svg)](https://circleci.com/gh/MicrosoftLearning/20532-DevelopingMicrosoftAzureSolutions/tree/master)
