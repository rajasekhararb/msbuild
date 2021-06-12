pipeline {
 agent any
 environment {
  dotnet = 'C:/Program Files (x86)/Microsoft Visual Studio/2019/Community/MSBuild/Current/Bin/MSBuild.exe'
 }
 stages {
  stage('Checkout') {
   steps {
     git credentialsId: 'rajasekhararb', url: 'https://github.com/rajasekhararb/SampleTest1.git', branch: 'master'
   }
  }
  
stage('Clean') {
   steps {
    bat 'dotnet clean'
   }
  }
  stage('Build') {
   steps {
    bat 'dotnet build --configuration Release'
   }
  }
  stage('Pack') {
   steps {
    bat 'dotnet pack --no-build --output nupkgs'
   }
  }
  stage('Publish') {
   steps {
    bat "dotnet nuget push **\\nupkgs\\*.nupkg -k yourApiKey -s http://myserver/artifactory/api/nuget/nuget-internal-stable/com/sample"
   }
  }
 }
}
