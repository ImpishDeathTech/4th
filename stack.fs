include objects.fs

cell negate CONSTANT -cell

OBJECT CLASS
    cell% FIELD stack-ptr

    SELECTOR PUSH
    SELECTOR POP
    SELECTOR PEEK
    SELECTOR EMPTY?
    SELECTOR SIZE
    SELECTOR CLEAR
END-CLASS StackI

StackI CLASS 
    :noname ( x me --  )
        stack-ptr
        tuck dup @ cell+ + !
        cell swap +! ;
    OVERRIDES PUSH

    :noname ( me -- x )
        stack-ptr 
        dup dup @ + @ 
        swap -cell swap + ! ;
    OVERRIDES POP

    :noname ( me -- x )
        stack-ptr
        dup @ + @ ;
    OVERRIDES PEEK

    :noname ( me -- f )
        stack-ptr
        @ 0= ;
    OVERRIDES EMPTY?

    :noname ( me -- u )
        stack-ptr
        @ cell / ;
    OVERRIDES SIZE

    :noname ( me -- )
        stack-ptr
        0 swap ! ;
    OVERRIDES CLEAR

    :noname { me_ }
        me_ stack-ptr 0 swap ! ;
    OVERRIDES CONSTRUCT
END-CLASS Filo

: STACK CREATE Filo dict-new ;

: NEW-STACK Filo heap-new ;
