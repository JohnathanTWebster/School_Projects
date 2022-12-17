       identification division.
       program-id. Program1.

       environment division.
       Input-Output Section.
       File-Control.
           select Employee-File
               assign to 'C:\Data\Data-In\CH5PP.DAT'
               organization is line sequential.

           select Sales-Report-File
               assign to 'C:\Data\Data-Out\Ch5i_payroll.rpt'
               organization is line sequential.


       configuration section.
       data division.
       File Section.
       FD Employee-File.
       01 Employee-Record.
         05 In-Employee-Number pic x(3).
         05 In-Employee-Last-Name pic x(20).
         05 In-Employee-First-Name pic x(10).
         05 In-Rank            pic xx.
         05 In-Salary          pic 9(6)V99.
       FD Sales-Report-File.
       01 Out-Report-Record    pic x(80).

       working-storage section.
       01 Working-Storage-Work-Areas.
         05 More-Records       pic x(3) value 'YES'.
         05 WS-Professor-CTR   pic 9(3) value zeros.
         05 WS-Associate-CTR   pic 9(3) value zeros.
         05 WS-Assistant-CTR   pic 9(3) value zeros.
         05 WS-Instructor-CTR  pic 9(3) value zeros.
         05 WS-Total-Fac-CNT   pic 9(4) value zeros.
         05 WS-Professor-Cost  pic 9(7)V99 value zeros.
         05 WS-Associate-Cost  pic 9(7)V99 value zeros.
         05 WS-Assistant-Cost  pic 9(7)V99 value zeros.
         05 WS-Instructor-cost pic 9(7)V99 value zeros.
         05 WS-Total-Cost      pic 9(9)V99 value zeros.
         05 New-Sale           pic 9(7)V99 value zeros.
       01 Headline-Blank       pic x(80) value spaces.
       01 Headline-Header1.
         05                    pic x(28) value spaces.
         05                    pic x(25) value
                               'University Payroll Report'.
         05                    pic x(27) value spaces.
       01 Headline-Header2.
         05                    pic x(30) value 'Rank'.
         05                    pic x(20) value 'No of Employees'.
         05                    pic x(30) value
                               'Cost of Proposed Increase     '.
       01 TL-Total-Line.
         05 TL-Rank            pic x(10).
         05                    pic x(26) value spaces.
         05 TL-Number-Of-Employees pic zz9.
         05                    pic x(17) value spaces.
         05 TL-Cost            pic $z,zzz,zz9.99.
         05                    pic x(11) value spaces.
       01 TL-Final-Total-Line.
         05                    pic x(22) value 'University Budget for '.
         05 TL-Number-Fac      pic zz9.
         05                    pic x(30) value
                               ' Faculty will be increased by   '.
         05 TL-Total-Cost      pic $z,zzz,zz9.99.
         05                    pic x(10) value spaces.
       procedure division.

******************************************
* Main Program                           *
******************************************

       100-Main-Module.
           open input Employee-File
             output Sales-Report-File.
           perform until More-Records = 'NO'
               read Employee-File
                   at end
                       move 'NO ' to More-Records
                   not at end
                       perform 200-Calc-Rtn
               end-read
           end-perform

           perform 300-Final-Rtn.
           Close Employee-File
             Sales-Report-File.
           stop run.

********************************************
* Loop through each record and update info *
********************************************


       200-Calc-Rtn.
           if In-Rank = 'FP'
               multiply In-Salary by .043 giving New-Sale
               add New-Sale to WS-Professor-Cost
               add 1 to WS-Professor-CTR
           end-if
           if In-Rank = 'AS'
               multiply In-Salary by .048 giving New-Sale
               add New-Sale to WS-Associate-Cost
               add 1 to Ws-Associate-CTR
           end-if
           if In-Rank = 'AP'
               multiply In-Salary by .052 giving New-Sale
               add New-Sale to WS-Assistant-Cost
               add 1 to WS-Assistant-CTR
           end-if
           if In-Rank = 'IP'
               multiply In-Salary by .057 giving New-Sale
               add New-Sale to WS-Instructor-cost
               add 1 to WS-Instructor-CTR
           end-if.
        
******************************************
* Close                                  *
******************************************


       300-Final-Rtn.
           write Out-Report-Record from Headline-Header1.
           write Out-Report-Record from Headline-Blank.
           write Out-Report-Record from Headline-Header2.
           write Out-Report-Record from Headline-Blank.
           move 'Full' to TL-Rank.
           move WS-Professor-CTR to TL-Number-Of-Employees.
           move WS-Professor-Cost to TL-Cost.
           write Out-Report-Record from TL-Total-Line.
           move 'Associate' to TL-Rank.
           move WS-Associate-CTR to TL-Number-Of-Employees.
           move WS-Associate-Cost to TL-Cost.
           write Out-Report-Record from TL-Total-Line.
           move 'Assistant' to TL-Rank.
           move WS-Assistant-CTR to TL-Number-Of-Employees.
           move WS-Assistant-Cost to TL-Cost.
           write Out-Report-Record from TL-Total-Line.
           move 'Instructor' to TL-Rank.
           move WS-Instructor-CTR to TL-Number-Of-Employees.
           move WS-Instructor-Cost to TL-Cost.
           write Out-Report-Record from TL-Total-Line.
           add WS-Professor-CTR, WS-Instructor-CTR, WS-Assistant-CTR,
             WS-Associate-CTR giving WS-Total-Fac-CNT.
           move WS-Total-Fac-CNT to TL-Number-Fac.
           add WS-Professor-Cost, WS-Instructor-cost, WS-Assistant-Cost
             , WS-Associate-Cost giving WS-Total-Cost.
           move WS-Total-Cost to TL-Total-Cost.
           write Out-Report-Record from Headline-Blank.
           write Out-Report-Record from TL-Final-Total-Line.
           
           

       end program Program1.
