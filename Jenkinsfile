pipeline {
    agent { label 'linux' }

    environment {
    DOCKERHUB_CREDENTIALS = credentials('dockerhub')
  }

    stages {

        stage("Checking Out") {            
            steps {
             echo "checking out..."
             checkout scm
            }


        }

         stage('Login') {
          steps {
            sh 'echo $DOCKERHUB_CREDENTIALS_PSW | docker login -u $DOCKERHUB_CREDENTIALS_USR --password-stdin'
          }
     }

        stage('Build') {
          steps {
            sh 'docker build -t talkit4vidya/jenkins-proj01:latest .'
          }
        }

         stage('Push') {
          steps {
            sh 'docker push talkit4vidya/jenkins-proj01:latest'
          }
    }

        // stage ("Docker Push"){
        //     steps {
        //         echo "Docker push"
        //         dir ("$WORKSPACE/docker") {
        //         script {
                    
        //             docker.withRegistry('', 'dockerhub') {
        //               def image = docker.build('talkit4vidya/jenkins-proj01')
        //               image.push()
        //             }
        //          }
        //        }
        //     }

           
        // }
    }

    post {
        success {
            echo 'pushed successfully'
        }

    }
}
