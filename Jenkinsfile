pipeline {
    agent any

    // tools {
    //     // Install the Maven version configured as "M3" and add it to the path.
    //     maven "M3"
    // }

    stages {
		stage('Checkout'){
			steps {
                echo 'Checking out..'
				checkout scm

			}
		}
        stage('Docker Push') {
            steps {
                echo 'Building..'
                // Get some code from a GitHub repository
                // git 'https://github.com/jglick/simple-maven-project-with-tests.git'

                // Run Maven on a Unix agent.
                echo 'Running in $WORKSPACE'

				

                // To run Maven on a Windows agent, use
                // bat "mvn -Dmaven.test.failure.ignore=true clean package"
            }            
        }

        // stage('Test') {
        //     steps {
        //         echo 'Testing..'
        //         script {
        //             // Running tests
        //             bat "dotnet test --no-restore --configuration Release"
        //         }
        //     }
        // }

		stage('Publish'){
			steps {
                echo 'Publish..'
				sh 'dotnet publish --no-restore --configuration Release --output .\\publish'

			}
		}
		
    }

	post {
		success {
			echo 'Build, pusblish successful'
		}
	}
}
