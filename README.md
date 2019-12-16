# HomeschoolGradesAndTranscripts

Full featured Windows application to track homeschool grades and create high school transcripts.

This application currently allows you to track grades for any number of students across different grade years. I am currently using it to be able to generate transcripts for my kids when they graduate high school, and there wasn't a good way to track their grades for 4 years without paying a bunch of money. 

<b>* UPDATE - </b>I have included an initial cut at generating transcripts. The PDF template I am using currently has a watermark on the pages, since I am using the free version of the software. The transcript will fill out up to 14 courses per grade year, 4 grade years total, and calculate grades and credits for each grade year. I will purchase the software to remove the watermark before I have to create an official transcript for college and will share the un-watermarked version at that point.

<b>* UPDATE - </b>Printing a report card is now completely configurable to the number of rating periods you have. Just make sure the rating period for each assignment is correct.

The data format is a json file. I am working to allow for multiple files, but right now there is only 1 file for everything.
<b>* UPDATE - </b>you can now have different file, with option to create new and change working file

There is a rudimentary feature for backup and version control of your gradebook data file using whatever backup features you already have (Google Backup and Sync, OneDrive, etc). I am working to make this more robust, as right now it expects a specific folder for syncing.
<b>* UPDATE - </b>you can now select which folder is synched for backup. The program will copy your gradebook file to the backup folder, leaving your backup software to sync it.
