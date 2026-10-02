pipeline {
    agent {
        kubernetes {
            yaml '''
apiVersion: v1
kind: Pod
spec:
  serviceAccountName: jenkins-agent
  containers:
    - name: kubectl
      image: bitnami/kubectl:latest
      command:
        - cat
      tty: true
'''
        }
    }

    stages {
        stage('Deploy to GKE') {
            steps {
                container('kubectl') {
                    sh 'kubectl apply -f deployment.yaml'
                }
            }
        }

        stage('Check GKE') {
            steps {
                container('kubectl') {
                    sh 'kubectl get pods'
                }
            }
        }
    }
}