@ECHO OFF
git init
git config --global credential.helper store
git remote add origin https://github.com/kural214/Dummy.git
git add .
git commit -m "Random Commit"
git push origin master


PAUSE