pipeline {
    agent any

    stages {
        stage('Nuget Restore') {
            steps {
                echo 'Restoring Nuget Packages...'
                nuget restore
                echo 'Nuget Pakages Restored'
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
