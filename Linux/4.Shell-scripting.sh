#!bin/bash 
#
# 4. Write a bash script that will convert a directory containing .wav files into .mp3. 
# Hint: use lame or menconder for the encoding.
#
# Important Information!
#
# This script converts all .wav files to .mp3 files 
# with lame codec. The files to convert must be located in the folder 
# where the script file is located.


for file in *.wav; do	
	echo $file
	STR=$(basename "$file" .wav)".mp3"
	#STR=$STR".mp3"
	lame --mp3input $file $STR
done

