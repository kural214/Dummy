@ECHO OFF
git init
git config --global credential.helper wincred
git remote add origin https://github.com/kural214/Dummy.git
git add .
git commit -m "Random Commit"
git config credential.helper store
git push origin master


PAUSE