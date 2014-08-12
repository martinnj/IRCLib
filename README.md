IRCLib
=========

Another pet project! This time, a simple IRC client based on an appropriate library, made by me! ;)


IRC Protocol
------------
[RFC can be found on ietf.org](http://tools.ietf.org/html/rfc1459)

For client:
 * Connect via telnet to a server (i.e. adams.freenode:6666)
 * Send PASS command:
...```PASS something```
 * Send NICK command:
...```NICK flankerdk```
 * Send USER command:
...```USER Flanker hostname servername :Martin J```
 * Await response
...Numeric 433 is ERR_ALREADYREGISTRED
 * More stuff coming here as I start working.

Anatomy of IRC Messages
-----------------------

Message format:
```[ :<prefix> ] <command> [ <params> ] <crlf>```
Things in square brackets are optional, prefix is the originator of the message,
only servers shiould ever send this. The command should be either three digits or
a valid IRC command. The params is a space seperated list of parameters for the command.
crlf is Carriage Return - Line Feed, the IRC line terminator.

An IRC Message must be at most 512 characters, including the CRLF terminator.

There is more to params, but I have yet to figure that out ;)

USER Message
------------
Send at the beginning of connection, used to register the client with the network:
```
USER <username> <mode> * :<realname>
```
(mode = 0 : visible, mode = 8 : invisible)
Possible replies:
 * ```ERR_NEEDMOREPARAMS```
 * ```ERR_ALREADYREGISTRED```


Command Responses
-----------------

The list below is by no way complete and serves just as notes to me while
writing the code.

Numerics in the range from 001 to 099 are used for client-server
connections only and should never travel between servers.  Replies
generated in the response to commands are found in the range from 200
to 399. Error replies are found in the range from 400 to 599.

Format:
```
<numeric> <reply-name> "<reply-text>"
```

Replies send to user upon registration:
```
001 RPL_WELCOME          "Welcome to the Internet Relay Network <nick>!<user>@<host>"
002 RPL_YOURHOST         "Your host is <servername>, running version <ver>"
003 RPL_CREATED          "This server was created <date>"
004 RPL_MYINFO           "<servername> <version> <available user modes> <available channel modes>"
005 RPL_ISUPPORT         "A lot of gibberish"
```

Error replies:
```
401 ERR_NOSUCHNICK       "<nickname> :No such nick/channel"
402 ERR_NOSUCHSERVER     "<server name> :No such server"
403 ERR_NOSUCHCHANNEL    "<channel name> :No such channel"
404 ERR_CANNOTSENDTOCHAN "<channel name> :Cannot send to channel"
405 ERR_TOOMANYCHANNELS  "<channel name> :You have joined too many channels"
406 ERR_WASNOSUCHNICK    "<nickname> :There was no such nickname"
407 ERR_TOOMANYTARGETS   "<target> :<error code> recipients. <abort message>"
409 ERR_NOORIGIN         ":No origin specified"
411 ERR_NORECIPIENT      ":No recipient given (<command>)"
412 ERR_NOTEXTTOSEND     ":No text to send"
413 ERR_NOTOPLEVEL       "<mask> :No toplevel domain specified"
414 ERR_WILDTOPLEVEL     "<mask> :Wildcard in toplevel domain"
```

License
-------
Copyright (C) 2014  Martin Jørgensen, http://martinnj.dk

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see [gnu.org](http://www.gnu.org/licenses/)

3rdparty stuff
--------------
The JSON.net library is provided by [James Newton-King](http://james.newtonking.com/json)
and comes with a seperate license, see ```3rdparty/json.net.license.txt```.

Icons are from the onebit set fount at [iconfinder](https://www.iconfinder.com/iconsets/onebit)

The FastColoredTExtBox control is provided by [Pavel Torgashov](https://github.com/PavelTorgashov/FastColoredTextBox)
and comes with a seperate license, see ```3rdparty/fastcoloredtextbox.license.txt```.