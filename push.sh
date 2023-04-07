#!/bin/bash

message=$1


cd script
npm i
npm run compile
cd ..
git add .
git commit -m "$message"
git push origin

echo "[INFO] Pushed to github successfully"
