       identification division.
       program-id. Chapter11.

       environment division.
       input-output section.
       file-control.
           select PYRL-MSTR
               assign to 'C:\Data\Data-In\Ch11_1102.dat'
               organization is line sequential.
           select Payroll-Rpt
               assign to 'C:\Data\Data-Out\Ch11_Payerr.rpt'
               organization is line sequential.

       configuration section.
       data division.
       FD PYRL-MSTR.
       01 PYRL-REC.
         05 Emp-No             pic 9(05).
         05 Emp-Name           pic x(20).
         05 Loc-Code.
           10 Terr             pic 9(02).
           10 Off-No           pic 9(02).
         05 Ann-Sale           pic 9(06).
         05 SSN                pic 9(09).
         05 No-Dep             pic 99.
         05 Job-Code           pic 99.
         05 Union-Dues         pic 999v99.
         05 Insurance          pic 999v99.
         05 Filler             pic x(22).

       FD Payroll-RPT.
       01 REPORT-RECORD        pic x(80).

       working-storage section.
       01 Assorted-Flags.
         05 More-Records       pic x(03) value 'YES'.
         05 Error-Flag         pic x(01) value 'N'.
         05 WS-PGNO            pic 9(03) value zero.
         05 EMPCNT             pic 9(03) value zero.
         05 ERRCNT             pic 9(03) value zero.
         05 LINECNT            pic 9(03) value zero.
         05 WS-Date.
           10 WS-YY            pic 9(02).
           10 WS-MM            pic 9(02).
           10 WS-DD            pic 9(02).

       01 Print-Title1.
         05 Filler             pic x(22) value spaces.
         05 Filler             pic x(08) value 'Payroll '.
         05 Filler             pic x(08) value 'Listing '.
         05 Filler             pic x(11) value spaces.
         05 filler             pic x(05) value 'Page:'.
         05 RPT-PGNO           pic zz9.
         05 Filler             pic x(03) value spaces.
         05 RPT-Date.
           10 RPT-MO           pic 9(02).
           10 filler           pic x value '/'.
           10 RPT-DY           pic 9(02).
           10 filler           pic x value '/'.
           10 RPT-YR           pic 9(04).
         05 Filler             pic x(10) value spaces.

       01 Print-Break1.
         05 Filler             pic x(80) value spaces.

       01 RPT-Rec.
         05 Filler             pic x(01) value space.
         05 RPT-EMP-NO         pic 9(05).
         05 Filler             pic x(01)  value space.
         05 RPT-EMP-NAME       pic x(20) value spaces.
         05 Filler             pic x(01)  value space.
         05 RPT-Terr           pic 9(02).
         05 Filler             pic x(01)  value space.
         05 RPT-Off-No         pic 9(02).
         05 Filler             pic x(02) value spaces.
         05 RPT-Ann-Sal        pic zz,zz9(06).
         05 Filler             pic x(02) value spaces.
         05 RPT-SSN            pic 9(09).
         05 Filler             pic x(01)  value space.
         05 RPT-No-Dep         pic 99.
         05 Filler             pic x(02) value space.
         05 RPT-Job-Code       pic 99.
         05 Filler             pic x(02) value space.
         05 RPT-Union-Dues     pic zz9.99.
         05 Filler             pic x(01) value spaces.
         05 RPT-Insur          pic zz9.99.
         05 Filler             pic x(01).

       01 Print-Err-Line.
         05 Filler             pic x(01) value space.
         05 Err-Emp-No         pic x(05).
         05 Filler             pic x(01) value space.
         05 Err-Emp-Name       pic x(20).
         05 Filler             pic x(53) value
              '************************* INVALID DATA **************'.
       01 Print-Total1.
         05 Filler             pic x(07) value spaces.
         05 Filler             pic x(10) value 'Total # Em'.
         05 Filler             pic x(10) value 'ployees Li'.
         05 Filler             pic x(07) value 'sted:  '.
         05 TOTCNT             pic zz9.
         05 Filler             pic x(07) value spaces.
         05 Filler             pic x(20) value 'Total Employee Data '.
         05 Filler             pic x(08) value 'Errors: '.
         05 TOTERR             pic zz9.
         05 Filler             pic x(05) value spaces.

       01 Print-Header1.
         05 Filler             pic x(01) value spaces.
         05 Filler             pic x(05) value 'EMP# '.
         05 Filler             pic x(01) value spaces.
         05 Filler             pic x(20) value 'Employee Name       '.
         05 Filler             pic x(10) value 'Terr/Off  '.
         05 Filler             pic x(10) value '  ANN SAL '.
         05 Filler             pic x(10) value '  SOC SEC '.
         05 Filler             pic x(04) value 'Dep '.
         05 Filler             pic x(04) value 'Job '.
         05 Filler             pic x(08) value ' U-Dues '.
         05 Filler             pic x(06) value ' Insur'.
         05 Filler             pic x(01) value spaces.
       
       procedure division.

       100-Main-Module.
           perform 110-StartUp-Module.
           perform until More-Records = 'No '
               read PYRL-MSTR
                   at end
                       move 'No ' to More-Records
                   not at end
                       perform 200-Loop-Rtn
               end-read
           end-perform
           perform 300-Close-Module.
           stop run.
           goback.

       110-Startup-Module.
           open input PYRL-MSTR
             output Payroll-RPT.

           move 1 to WS-PGNO
           accept WS-Date from date
           Move WS-MM to RPT-MO
           move WS-DD to RPT-DY
           add WS-YY 2000 giving RPT-YR
           move WS-PGNO to RPT-PGNO

           write REPORT-RECORD from Print-Title1.
           write REPORT-RECORD from Print-Break1.
           write REPORT-RECORD from Print-Header1.
           move 3 to LINECNT.
       
       200-Loop-Rtn.
           if LINECNT < 40
               continue
           else
               perform 210-Page-Break-Module
           end-if.

           initialize RPT-Rec.

           if Emp-No not numeric
               move 'Y' to Error-Flag
               move Emp-No to Err-Emp-No
           else
               move Emp-No to RPT-EMP-NO, Err-Emp-No
           end-if.

           if Emp-Name = spaces
               move 'Y' to Error-Flag
               move spaces to RPT-EMP-NAME, ERR-Emp-Name
           else
               move Emp-Name to RPT-EMP-NAME, Err-Emp-Name
           end-if.

           if Terr not numeric
               move 'Y' to Error-Flag
           else
               move Terr to RPT-Terr
           end-if.

           if Off-No not numeric
               move 'Y' to Error-Flag
           else
               move Off-No to RPT-Off-No
           end-if.

           if Ann-Sale not numeric
               move 'Y' to Error-Flag
           else
               if Ann-Sale > 125000
                   move 'Y' to Error-Flag
               else
                   move Ann-Sale to RPT-Ann-Sal
               end-if
           end-if.

           If SSN not numeric
               move 'Y' to Error-Flag
           else
               move SSN to RPT-SSN
           end-if.

           if No-Dep not numeric
               move 'Y' to Error-Flag
           else
               move No-Dep to RPT-No-Dep
           end-if.

           if Job-Code not numeric or Job-Code = 0
               move 'Y' to Error-Flag
           else
               move Job-Code to RPT-Job-Code
           end-if.

           if Union-Dues not numeric
               move 'Y' to Error-Flag
           else
               move Union-Dues to RPT-Union-Dues
           end-if.

           if Insurance not numeric
               move 'Y' to Error-Flag
           else
               move Insurance to RPT-Insur
           end-if.

           add 1 to EMPCNT LINECNT

           if Error-Flag = 'N'
               write REPORT-RECORD from RPT-Rec
           else
               write REPORT-RECORD from Print-Err-Line
               add 1 to ERRCNT
               move 'N' to Error-Flag
           end-if.



       210-Page-Break-Module.
           add 1 to WS-PGNO
           move WS-PGNO to RPT-PGNO.

           write REPORT-RECORD from Print-Title1 after page.
           write REPORT-RECORD from Print-Break1.
           write REPORT-RECORD from Print-Break1.
           write REPORT-RECORD from Print-Header1.
           move 3 to LINECNT.

       300-Close-Module.
           move EMPCNT to TOTCNT.
           move ERRCNT to TOTERR.

           write REPORT-RECORD from Print-Break1.
           write REPORT-RECORD from Print-Total1.
           close PYRL-MSTR Payroll-Rpt.

       end program Chapter11.
