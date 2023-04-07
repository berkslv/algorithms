#!/bin/bash

message=$1
CYAN='\033[1;36m'
NC='\033[0m'


cd script
npm i
npm run compile
cd ..
git add .
git commit -m "$message"
git push origin

echo "${CYAN}[INFO]${NC} Pushed to github successfully"
