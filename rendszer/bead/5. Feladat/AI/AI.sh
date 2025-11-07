#!/bin/bash

# Ellenőrizzük, hogy kapott-e fájlnevet
if [ $# -ne 1 ]; then
    echo "Használat: $0 fajlnev"
    exit 1
fi

file="$1"

# Ellenőrizzük, hogy létezik-e a fájl
if [ ! -f "$file" ]; then
    echo "Hiba: A megadott fájl nem létezik!"
    exit 2
fi

# Beolvassuk a szavakat egy tömbbe
mapfile -t words < "$file"

maxcount=0
maxword=""

# Minden szóhoz megszámoljuk, hány másik szóban szerepel részszóként
for w in "${words[@]}"; do
    count=0
    for other in "${words[@]}"; do
        if [[ "$other" == *"$w"* && "$other" != "$w" ]]; then
            ((count++))
        fi
    done

    if (( count > maxcount )); then
        maxcount=$count
        maxword="$w"
    fi
done

echo "A legtöbb másik szóban részszóként szereplő szó: '$maxword' ($maxcount találat)"
