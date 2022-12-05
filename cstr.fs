\ convert Forth strings to zero-terminated strings

\ Copyright (C) 2008 Free Software Foundation, Inc.

\ This file is part of Gforth.

\ Gforth is free software; you can redistribute it and/or
\ modify it under the terms of the GNU General Public License
\ as published by the Free Software Foundation, either version 3
\ of the License, or (at your option) any later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http://www.gnu.org/licenses/.
\ 
\ This version has been modified by ImpishDeathTech to bind 
\ and wrap original cstr functions as well
\ 

C-LIBRARY cstr

C-FUNCTION CSTR       cstr       a n n -- a ( c-addr u fclear -- c-addr2 )
C-FUNCTION ~CSTR      tilde_cstr a n n -- a ( c-addr u fclear -- c-addr2 )

\c #include <stdlib.h>
\c #include <string.h>

( number conversion )

\ float atof(char* n);
C-FUNCTION C-ATOF atof a -- r

\ int atoi(char* n);
C-FUNCTION C-ATOI atoi a -- n

( length )

\ int strlen(char* target);
C-FUNCTION C-STRLEN strlen     a     -- n

( copying )

\ char* strcpy(char* destination, const char* source);
C-FUNCTION C-STRCPY  strcpy    a a   -- a
C-FUNCTION C-STRNCPY strncpy   a a n -- a

C-FUNCTION C-MEMCPY  memcpy    a a n -- a

( concatenation )

\ char* strcat(char* destination, const char* source);
C-FUNCTION C-STRCAT  strcat    a a   -- a
C-FUNCTION C-STRNCAT strncat   a a n -- a

( error )

C-FUNCTION C-STRERR strerror   n     -- a

END-C-LIBRARY

: $>F ( c-addr -- r )
    c-atof ;

: $>S ( c-addr -- u )
    c-atoi ;

: STRLEN ( c-addr -- c-addr u )
    dup c-strlen ;

: STRCPY { a_ c_ } ( -- c-addr u )
    a_ c_ c-strcpy 
    strlen false cstr 
    dup a_ !
    strlen ;

: STRCAT  { a_ c_ } ( -- c-addr u )
    nil str-buf !
    a_ @ c_ c-strcat 
    strlen false cstr 
    dup a_ !
    strlen ;


: STRNCPY { a_ c_ n_ } ( -- c-addr u ) 
    a_ c_ n_ c-strncpy 
    strlen false cstr 
    dup a_ ! 
    strlen ;

: STRNCAT  { a_ c_ n_ } ( -- c-addr u )  
    a_ @ c_ n_ c-strncat
    strlen false cstr
    dup a_ !
    strlen ;
