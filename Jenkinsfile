pipeline {
    agent any

    stages {

        stage("Checking Out") {            
            steps {
             echo "checking out..."
             checkout scm
            }


        }

        stage ("Docker Push"){
            
            script {
                echo "Docker push"
                docker.withRegistry('', 'dockerhub')
                def image = docker.build('talkit4vidya/jenkins-proj01')
                image.push()
            }

           
        }
    }

    post {
        always {
            echo 'pushed successfully'
        }

    }
}
