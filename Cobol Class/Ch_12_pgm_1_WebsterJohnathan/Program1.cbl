       identification division.
       program-id. Program12.

       environment division.
       input-output section.
       file-control.
           select chapter12in
               assign to 'C:\Data\Data-In\Ch12_1202.dat'
               organization is line sequential.
           select chapter12out
               assign to 'C:\Data\Data-Out\Ch12sal.rpt'
               organization is line sequential.
           select chapter12tax
               assign to 'C:\Data\Data-In\Ch12_CH1202.tab'
               organization is line sequential.


       configuration section.

       data division.

       file section.
       FD chapter12in.
       01 ch12recin.
         05 EMP-NUM            pic 9(05).
         05 EMP-NAME           pic x(20).
         05 filler             pic x(04).
         05 PAY                pic 9(06).
         05 filler             pic 9(09).
         05 NUMDEP             pic 9(02).
         05 filler             pic x(34).

       FD chapter12tax.
       01 ch12taxin.
         05 INCOME             pic 9(06).
         05 FED                pic v999.
         05 STATE              pic v999.

       FD chapter12out.
       01 ch12recout           pic x(80).

       working-storage section.
       01 STORED-AREAS.
         05 MORE-RECS          pic x(03) value 'YES'.
         05 WS-LINE-CT         pic 99 value 0.
         05 WS-BLANK            pic x(80).
         05 PAGECNT            pic 99 value 0.
         05  WS-Date.
           10 WS-YEAR          pic 9999.
           10 WS-MONTH         pic 99.
           10 WS-DAY           pic 99.
         05 STDDED             pic 9(04)v99.
         05 DEPDED             pic 9(04)v99.
         05 SST                pic 9(04)v99.
         05 MEDI               pic 9(04)v99.
         05 FICA               pic 9(04)v99.
         05 taxable            pic 9(06)v99.
         05 ANNET              pic 9(06)v99.
         05 monet              pic 9(06)v99.

       01 WS-TAX.
         05 Tax-table          occurs 20 times indexed by xi.
           10 Tax-Income       pic 9(06).
           10 FED-Tax          pic v999.
           10 State-Tax        pic v999.


       01 WS-RPT-TITLE.
         05 filler             pic x(30) value spaces.
         05 WS-TITLE           pic x(21) value 'Monthly Salary Report'.
         05 filler             pic x(05) value spaces.
         05 DATE-OUT.
           10 MONTH-OUT        pic 99.
           10 filler           pic x value '/'.
           10 DAY-OUT          pic 99.
           10 filler           pic x value '/'.
           10 YEAR-OUT         pic 9999.
           10 filler           pic x(14) value spaces.

       01 WS-COLUMN-HDR.
         05                    pic x(04) value spaces.
         05                    pic x(13) value 'Employee Name'.
         05                    pic x(14) value spaces.
         05                    pic x(21) value 'Monthly Take-Home Pay'.
         05                    pic x(28) value spaces.

       01 DETAIL-REC.
         05 EMP-NUM-OUT        pic x(05).
         05                    pic x(01) value spaces.
         05 EMP-NAME-OUT       pic x(20).
         05                    pic x(05) value spaces.
         05 Month-Net          pic $zz,zz9.99.
         05                    pic x(09) value spaces.
         05 annsal             pic $zzz,zz9.
         



       procedure division.

       100-Main-Module.
           perform 110-Initialize-Return.

           perform until MORE-RECS = 'NO '
               read chapter12in
                   at end
                       move 'NO ' to MORE-RECS
                   not at end
                       perform 300-Calculate-Return
               end-read
           end-perform

           perform End-Job-Return.
           goback.

       110-Initialize-Return.
           open input chapter12in
             chapter12tax
             output chapter12out.

           perform varying xi from 1 by 1 until xi > 6
               read chapter12tax into Tax-table(xi)
           end-perform.
         



           write ch12recout from WS-RPT-TITLE.
           accept WS-Date from date
           move WS-MONTH to MONTH-OUT.
           move WS-Day to DAY-OUT.
           add WS-YEAR 2000 giving YEAR-OUT.

           write ch12recout from WS-BLANK.
           write ch12recout from WS-COLUMN-HDR.
           write ch12recout from WS-BLANK.

       300-Calculate-Return.
           move EMP-NUM to EMP-NUM-OUT
           move EMP-NAME to EMP-NAME-OUT
           
      *    move PAY to annsal.

           if PAY > 10000
               compute STDDED rounded = 10000 * .1
           else
               compute STDDED rounded = PAY * .1
           end-if

           compute DEPDED rounded = 2000 * NUMDEP.

           if PAY <= 90000
               compute SST rounded = PAY * .062
           else
               compute SST rounded  = 90000 * .062
           end-if

          

           compute MEDI rounded  = pay * .0145
           compute FICA rounded  = SST + MEDI
           compute taxable rounded = PAY - STDDED - depded

           

           

           perform 310-Get-Taxrates.

           compute ANNET   = PAY - (STATE * taxable) - (FED * 
           taxable) - FICA.
           compute monet   = ANNET / 12.
           move monet to Month-Net.
           write ch12recout from DETAIL-REC.

       310-Get-Taxrates.
           set xi to 1.

           search Tax-table
               
               when taxable > Tax-Income(xi)
                   continue
               when taxable <= Tax-Income(xi)
                   move FED-Tax(xi) to FED  
                   move State-Tax(xi) to state 
                
                   
           end-search.


           


       End-Job-Return.
           close chapter12in
             chapter12out
             chapter12tax.
       end program Program12.
