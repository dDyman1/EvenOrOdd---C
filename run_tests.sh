# add this file to the root of the repo
# name it run_tests.sh
# set the run command to the text between the brakets on then next line
# [. ./run_tests]
# the first line of the file should be the line that reads #!/bin/bash
# basicaly, delete this line and everything above it
#!/bin/bash
export DOTNET_CLI_HOME=/tmp
dotnet test