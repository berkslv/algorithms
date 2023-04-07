#!/bin/bash

message=$1
CYAN='\033[0;36m'
NC='\033[0m'


cd script
npm i
npm run compile
cd ..
git add .
git commit -m "$message"
git push origin

echo "${CYAN}love${NC} Pushed to github successfully"
