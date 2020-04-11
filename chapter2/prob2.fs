\ Write a phrase which will reverse the order of the top four
\ items on the stack: that is,  (l 2 3 4 -- 4 3 2 l)

: 4swap ( a b c d -- d c b a ) swap 2swap swap ;
