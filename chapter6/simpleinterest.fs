\ write a program for calculating simple interest
\ give principal, rate and time

: simple-interest ( priciple rate time -- )
    100 * * / . ;

: lv-simple-interest ( priciple rate time -- )
    { priciple rate time }
    100 priciple rate time * * / . ;

1200 1 1 simple-interest
1000 12 1 lv-simple-interest