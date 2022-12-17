       identification division.
       program-id. Program16.

       environment division.
       Input-output section.
       File-control.
           select Item-Disk assign to 'C:\Data\Data-In\ch9_0903.dat'
               organization is line sequential.
           select Inflation-Report assign to 'C:\Data\Data-Out\Ch16.rpt'
               organization is line sequential.

       configuration section.

       data division.
       FD Item-Disk.
       01 Item-Rec.
         05 Item-Number        pic x(05).
         05 Item-Desc          pic x(20).
         05 Item-Cost          pic 999V99.
         05 Filler             pic x(25).
         05 Filler             pic x(25).

       FD Inflation-Report.
       01 Inflation-Rec        pic x(80).

       working-storage section.

       01 Flags-And-Indicators.
         05 More-Records       pic xxx value 'YES'.
         05 Date-Field.
           10 Year-Field       pic 9(04).
           10 Month-Field      pic 9(02).
           10 Day-Filed        pic 9(02).
         05 Cost-Calc          pic 9(06)V9(02).
         05 Page-Num           pic 9(03) value zero.
         05 YR-IDX             pic 99 value zero.

       01 Blank-Line           pic x(80) value spaces.

       01 LINKAGE-DATA.
         05 COST-CALCULATION   pic 9(03)v9(02).
         05 INFLATION-A        pic 99.
         05 YEAR-C             pic 99.

       01 Header1.
         05                    pic x(19) value spaces.
         05                    pic x(17) value 'Inflation Report'.
         05                    pic x(12) value spaces.
         05 Date-Today.
           10 Out-Month        pic z9.
           10                  pic x value '/'.
           10 Out-Day          pic z9.
           10                  pic x value '/'.
           10 Out-Year         pic 9(04).
         05                    pic x(04) value spaces.
         05                    pic x(10) value spaces.
         05                    pic x(05) value 'Page '.
         05 Page-No            pic zz9 value zero.

       01 Header2.
         05                    pic x(04) value spaces.
         05                    pic x(13) value 'Item Number'.
         05                    pic x(05) value spaces.
         05 Item-Num           pic 9(05).
         05                    pic x(53) value spaces.

       01 Header3.
         05                    pic x(04) value spaces.
         05                    pic x(18) value 'Item description'.
         05 In-Desc            pic x(20).
         05                    pic x(38) value spaces.

       01 Header4.
         05                    pic x(04) value spaces.
         05                    pic x(13) value 'Item cost'.
         05                    pic x(05) value spaces.
         05 In-Cost            pic $zz,zz9.99.
         05                    pic x(48) value spaces.
       01 Header5.
         05                    pic x(25) value spaces.
         05                    pic x(04) value 'Year'.
         05                    pic x(05) value spaces.
         05                    pic x(14) value 'Inflation Rate'.
         05                    pic x(04) value spaces.
         05                    pic x(21) value 'Item Cost w/Inflation'.
         05                    pic x(05) value spaces.

       01 Data-01.
         05                    pic x(26) value spaces.
         05 Year-Calc          pic z9.
         05                    pic x(12) value spaces.
         05 Inflation-Calc     pic z9.
         05                    pic x value '%'.
         05                    pic x(14) value spaces.
         05 Cost-Field-Calc    pic $zzz,zz9.99.
         05                    pic x(12) value spaces.

       procedure division.

       100-Main-Module.
           perform 150-Housekeeping-Start.

           perform until More-Records = 'No '
               read Item-Disk
                   at end
                       Move 'No ' to More-Records
                   not at end
                       perform 200-Calc-Rpt-Rtn

                       perform 300-CALCULATE-RTN
               end-read
           end-perform.
           close Item-Disk
             Inflation-Report.
           goback.

       150-Housekeeping-Start.
           open input Item-Disk
             output Inflation-Report.

           move function current-date to Date-Field.
           move Day-Filed to Out-Day
           move Month-Field to Out-Month
           move Year-Field to Out-Year.

       200-Calc-Rpt-Rtn.
           add 1 to Page-Num
           move Page-Num to Page-No
           move Item-Number to Item-Num
           move Item-Desc to In-Desc
           move Item-Cost to In-Cost, COST-CALCULATION.

           move 1 to YEAR-C

           perform 400-Heading-Rtn.

       300-CALCULATE-RTN.


           perform until YEAR-C > 10

               call 'INFLTN' using LINKAGE-DATA
               move INFLATION-A to Inflation-Calc
               move YEAR-C to Year-Calc
           move COST-CALCULATION to Cost-Field-Calc
           write Inflation-Rec from Data-01 after advancing 1 line
           add 1 to YEAR-C
             end-perform.
           write Inflation-Rec from Blank-Line after advancing 1.

    

       400-Heading-Rtn.
           write Inflation-Rec from Blank-Line after advancing page.
           write Inflation-Rec from Header1 after advancing 1.
           write Inflation-Rec from Blank-Line after advancing 1.
           write Inflation-Rec from Header2 after advancing 1.
           write Inflation-Rec from Header3 after advancing 1.
           write Inflation-Rec from Header4 after advancing 1.
           write Inflation-Rec from Blank-Line after advancing 1.
           write Inflation-Rec from Header5 after advancing 1.

       end program Program16.
