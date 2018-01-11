# HomeschoolGradesAndTranscripts

Windows application to track homeschool grades and create high school transcripts.

This application currently allows you to track grades for any number of students across different grade years. I am writing it to be able to generate transcripts for my kids when they graduate high school, and there wasn't a good way to track their grades for 4 years without paying a bunch of money. 
* UPDATE - I have included an initial cut at generating transcripts. The PDF template I am using currently has a watermark on the pages, since I am using the free version of the software. The transcript will fill out up to 14 courses per grade year, 4 grade years total, and calculate grades for each grade year.

I have recently added the feature to generate a report card for your reporting periods. This currently is set up for 6 week periods - later I will make this configurable.

The data format is a json file. I am working to allow for multiple files, but right now there is only 1 file for everything.
* UPDATE - you can now have different file, with option to create new and change working file

There is a rudimentary feature for backup and version control of your gradebook data file using whatever backup features you already have (Google Backup and Sync, OneDrive, etc). I am working to make this more robust, as right now it expects a specific folder for syncing.
* UPDATE - you can now select which folder is synched for backup. The program will copy your gradebook file to the backup folder, leaving your backup software to sync it.

* Coming soon -- This application will also keep track of extracurricular activities, which look good on college transcripts.

* Coming eventually -- I want to learn how to write mobile apps, so I plan on converting this to an Android app at some point in the next year or two.
