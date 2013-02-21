RemoteUTorrentClickHandler
=============

The problem:

- I have a home server running uTorrent.
- I browse a website which shows me a magnet link.
- I click on the magnet link
- uTorrent runs locally and I am sad.
- I spent my time right clicking "copy link" and pasting the links into the uTorrent webUi.
- I am sad.

Solution!
=========

- I build or download this tiny tiny tiny app.
- I copy it somewhere. Like program files or something.
- I run it as an administrator and it adds a handler mapping.
- I open the config file: RemoteUTorrentClickHandler.exe.config and fill in my uTorrent Uri, username and password. Sorry, plain text. Send me a pull request for more ;)
- Done, I can now click links in a browser and have torrent added remotely.