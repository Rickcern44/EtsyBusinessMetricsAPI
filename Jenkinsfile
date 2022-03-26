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
                sh(script: "dotnet build /var/lib/jenkins/workspace/EtsyBusinessMetricsAPI_dev/EtsyBusinessMetricsAPI.sln", returnStdout: true)
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
