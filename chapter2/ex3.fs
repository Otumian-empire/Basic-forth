( Write a definition called <ROT, which rotates the top 3 stack items in the opposite direction from ROT; that is, 
a b c becomes c a b )

: <ROT ( a b c -- c a b ) swap rot swap ;

