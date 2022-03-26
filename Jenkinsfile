pipeline {
    agent any

    stages {
        stage('Restore Nuget') {
            steps {
                echo 'Restoring Nuget Packages...'
                dir('.nuget'){
                    bat 'NuGet.exe restore' 
                }
            }
        }
        stage('Build') {
            steps {
                echo 'Building..'
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
