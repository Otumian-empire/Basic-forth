( Write a phrase which flips three items on the stack, leaving 
the middle number in the middle; that is,
 a b c becomes c b a )
 
: flip ( a b c -- c b a ) swap rot ;
