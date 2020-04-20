\ Next define BOX which prints out a rectangle  of stars, given
\ the width and height (number of lines), using the stack order
\ (width height -- ) .

\ 10 3 BOX
\ **********
\ **********
\ ********** ok


\ using local variables
: BOX ( width height -- )
	{ weight height }
	CR
	height 0 DO 
    weight 0 DO
				." *"
		LOOP CR
	LOOP CR ;
	
10 3 BOX

