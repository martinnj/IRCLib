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