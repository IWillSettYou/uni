#!/bin/bash
echo "$1 file vizsgálása..."
tr -s ' ' '\n' < $1 > output.txt

bigNum=0
bigWord=""

while read word; do
    db=$(grep -c "$word" output.txt)
    db=$((db - 1))
    if [ $db -gt $bigNum ]; then
        bigNum=$db
        bigWord=$word
    fi
done < output.txt

echo "A legtöbbször megtalálható szó a szavakban a(z) '$bigWord', $bigNum alkalommal"