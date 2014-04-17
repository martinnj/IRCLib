IRCLib
=========

Another pet project! This time, a simple IRC client based on an appropriate library, made by me! ;)


IRC Protocol
------------
[RFC can be found on ietf.org](https://tools.ietf.org/html/rfc2812)

For client:
 * Connect via telnet to a server (i.e. adams.freenode:6666)
 * Send USER command:
...USER Flanker 0 * :Martin J
 * Send NICK command:
...NICK <username>
 * Await response
...Numeric 433 is ERR_ALREADYREGISTRED


USER Message
------------
Send at the beginning of connection, used to register the client with the network:
USER <username> <mode> * :<realname>
(mode = 0 : visible, mode = 8 : invisible)
Possible replies:
 * ERR_NEEDMOREPARAMS
 * ERR_ALREADYREGISTRED


Command Responses
-----------------
Numerics in the range from 001 to 099 are used for client-server
connections only and should never travel between servers.  Replies
generated in the response to commands are found in the range from 200
to 399.

Format:
<numeric> <reply-name> "<reply-text>"

Replies send to user upon registration:
```
001 RPL_WELCOME           "Welcome to the Internet Relay Network <nick>!<user>@<host>"
002 RPL_YOURHOST          "Your host is <servername>, running version <ver>"
003 RPL_CREATED           "This server was created <date>"
004 RPL_MYINFO            "<servername> <version> <available user modes> <available channel modes>"
```
Reply send by the server when suggesting alternate host due to
capacity issues or similar, consider it a rerpoute suggestion/bounce:
```
005 RPL_BOUNCE            "Try server <server name>, port <port number>"
```