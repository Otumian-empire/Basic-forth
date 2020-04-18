\ First create a word named STARS which will print out n stars 
\ on the same line, given n on the stack:
\ 10 STARS Gives ********** OK.

: STARS ( n -- )
	0 DO ." *" LOOP ;

: TESTSTARS ( -- )
	3 STARS cr
	5 STARS cr
	13 STARS cr ;
	
TESTSTARS


