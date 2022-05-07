#!/bin/bash
git status && 
git add . && 
git commit -am "Regular changes" &&
git push origin main && 
git pull origin main
