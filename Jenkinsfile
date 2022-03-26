pipeline {
    agent any

    stages {
        stage ('Clean Workspace'){
            steps{
                echo 'Cleaning...'
                cleanWs()
            }
        }
        stage('Build') {
            steps {
                sh(script: "dotnet restore", returnStdout: true)
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
