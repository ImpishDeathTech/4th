\ check a char's type or convert it's case
\
\ This file wraps the ctype.h functions into forth-frendly boolean functions
\
\
\ BSD 3-Clause License
\ 
\ Copyright (c) 2022, Christopher Stephen Rafuse
\ All rights reserved.
\ 
\ Redistribution and use in source and binary forms, with or without
\ modification, are permitted provided that the following conditions are met:
\ 
\ 1. Redistributions of source code must retain the above copyright notice, this
\    list of conditions and the following disclaimer.
\ 
\ 2. Redistributions in binary form must reproduce the above copyright notice,
\    this list of conditions and the following disclaimer in the documentation
\    and/or other materials provided with the distribution.
\ 
\ 3. Neither the name of the copyright holder nor the names of its
\    contributors may be used to endorse or promote products derived from
\    this software without specific prior written permission.
\ 
\ THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
\ AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
\ IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
\ DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
\ FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
\ DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
\ SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
\ CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
\ OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
\ OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

C-LIBRARY ctype
\c #include <ctype.h>

C-FUNCTION ISALNUM   isalnum   n -- n
: ALNUM? ( u -- f )
    isalnum 0= 
    IF   false
    ELSE true
    THEN ;

C-FUNCTION ISBLANK   isblank   n -- n
: BLANK? ( u -- f )
    isblank 0=
    IF   false
    ELSE true 
    THEN ;

C-FUNCTION ISCNTRL   iscntrl   n -- n
: CTRL?  ( u -- f )
    iscntrl 0=
    IF   false
    ELSE true
    THEN ;

C-FUNCTION ISXDIGIT  isxdigit  n -- n
: XDIGIT? ( u -- f )
    isxdigit 0=
    IF   false
    ELSE true
    THEN ;

C-FUNCTION ISGRAPH  isgraph    n -- n
: GRAPH? ( u -- f )
    isgraph 0=
    IF   false
    ELSE true
    THEN ;

C-FUNCTION ISLOWER  islower    n -- n
: LOWER? ( u -- f )
    islower 0=
    IF   false
    ELSE true
    THEN ;

C-FUNCTION ISUPPER  isupper    n -- n
: UPPER? ( u -- f )
    isupper 0=
    IF   false
    ELSE true
    THEN ;

C-FUNCTION ISPRINT  isprint    n -- n
: PRINT?  ( u -- f )
    isprint 0=
    IF   false
    ELSE true  
    THEN ;

C-FUNCTION ISSPACE  isspace    n -- n
: SPACE? ( u -- f )
    isspace 0=
    IF   false
    ELSE true
    THEN ;

C-FUNCTION ISPUNCT  ispunct    n -- n
: PUNCT? ( u -- f )
    ispunct 0=
    IF   false
    ELSE true
    THEN ;

C-FUNCTION TOLOWER  tolower    n -- n 


END-C-LIBRARY

HEX

00 CONSTANT '\0'
07 CONSTANT '\a'
08 CONSTANT '\b'
09 CONSTANT '\t'
0A CONSTANT '\n'
0B CONSTANT '\v'
0C CONSTANT '\f'
0D CONSTANT '\r'
20 CONSTANT '\s'

DECIMAL

: NUL '\0' EMIT ;
: BEL '\a' EMIT ;
: BS  '\b' EMIT ;
: HT  '\t' EMIT ;
: LF  '\n' EMIT ;
: VT  '\v' EMIT ;
: FFD '\f' EMIT ;

' CR ALIAS .CR
: CR  '\r' EMIT ;
