IRCLib
=========

Another pet project! This time, a simple IRC client based on an appropriate library, made by me! ;)


IRC Protocol
------------
[RFC can be found on ietf.org](https://tools.ietf.org/html/rfc2812)

For client:
 - Connect via telnet to a server (i.e. adams.freenode:6666)
 - Send USER command:
   USER <username> <mode> * :<realname>     (mode = 0 : visible, mode = 8 : invisible)
 - Send NICK command:
   NICK <username>
