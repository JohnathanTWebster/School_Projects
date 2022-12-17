       identification division.
       program-id.  Chapter8.

       environment division.
       Input-Output Section.
           select Student-Rec
               assign to 'C:\Data\Data-In\Ch8_0808.dat'
               organization is line sequential.
           select Summary-Rpt
               assign to 'C:\Data\Data-Out\OUT_Ch8rpt.rpt'
               organization is line sequential.

       configuration section.

       data division.
       File section.

       FD Student-Rec.
       01 Student-File.
         05 Stud-Soc           pic x(09).
         05 Stud-Name          pic x(21).
         05 Class-Code         pic x(01).
           88 Freshman         value '1'.
           88 Sophmore         value '2'.
           88 Junior           value '3'.
           88 Senior           value '4'.
         05 School-Code        pic x(01).
           88 Business         value '1'.
           88 Libarts          value '2'.
           88 Engneering       value '3'.
         05 GPA                pic 9V99.
         05 Credits            pic 999.
       FD Summary-Rpt.
       01 Summary-record.
         05 filler             pic x(80).


       working-storage section.
       01 WS-Flags-Indicators.
         05 WS-More-Recs       pic x(03) value 'YES'.
       01 WS-Counters.
         05 WS-TOT-Stud        pic 9(04) value 0.
         05 WS-CNT-Stud-U2gpa  pic 9(04) value 0.
         05 WS-CNT-Stud-2-3gpa pic 9(04) value 0.
         05 WS-CNT-Stud-A3gpa  pic 9(04) value 0.
         05 WS-CNT-A3-Bus      pic 9(04) value 0.
         05 WS-CNT-A3-Lan      pic 9(04) value 0.
         05 WS-CNT-A3-Eng      pic 9(04) value 0.
         05 WS-CNT-GT100cr-LT2 pic 9(04) value 0.
         05 WS-CNT-A3gpa-FR    pic 9(04) value 0.
         05 WS-CNT-A3gpa-SO    pic 9(04) value 0.
         05 WS-CNT-A3gpa-JR    pic 9(04) value 0.
         05 WS-CNT-A3gpa-SR    pic 9(04) value 0.
         05 WS-Miss-Class      pic 9(04) value 0.
         05 WS-Miss-School     pic 9(04) value 0.

       01 WS-RPT-Lines.
         05 WS-Blank           pic x(80) value spaces.
         05 WS-Title1.
           10 Filler           pic x(14) value spaces.
           10 Filler           pic x(26) value
                               '  Pass-EM State College SU'.
           10 Filler           pic x(26) value
                               'MMARY Student Percenteages'.
           10 Filler           pic x(14) value spaces.
         05 WS-Title2.
           10 Filler           pic x(22).
           10 Filler           pic x(18) value
                               'total # Students: '.
           10 Num-Stud         pic zzz9.
           10 Filler           pic x(12) value '     Percent'.
           10 Filler           pic x(24) value spaces.
         05 Rpt-Line-A.
           10 Filler           pic x(04) value spaces.
           10 Filler           pic x(24) value
                               ' % of students with GPA '.
           10 RPTA-GPA-LIT     pic x(12).
             88 LT20           value ' < 2.0      '.
             88 2to3           value ' 2.0 - 3.0  '.
             88 GT30           value ' > 3.0      '.
           10 RPTA-Counter     pic zzz9.
           10 Filler           pic x(05).
           10 RPTA-Percentage  pic zz9.99.
           10 Filler           pic x value '%'.
           10 Filler           pic x(24) value spaces.


       procedure division.

       100-Main-Module.
           open input Student-Rec
             output Summary-Rpt
           perform until WS-More-Recs = 'NO '
               read Student-Rec
                   at end
                       move 'NO ' to WS-More-Recs
                   not at end
                       add 1 to WS-TOT-Stud
                       perform 200-Module-Count-Data
               end-read
           end-perform.

           perform 300-Module-RPT-Setup thru 310-Module-RPTA.
           close Student-Rec Summary-Rpt.
           goback.

       200-Module-Count-Data.
           if GPA < 2.0
               add 1 to WS-CNT-Stud-U2gpa
           else
               if GPA > 2.0 and < 3.0
                   add 1 to WS-CNT-Stud-2-3gpa
               else
                   add 1 to WS-CNT-Stud-A3gpa
                   perform 210-3GPA-Counts
               end-if
           end-if.

       210-3GPA-Counts.
           evaluate Class-Code
               when '1'
                   add 1 to WS-CNT-A3gpa-FR
               when '2'
                   add 1 to WS-CNT-A3gpa-SO
               when '3'
                   add 1 to WS-CNT-A3gpa-JR
               when '4'
                   add 1 to WS-CNT-A3gpa-SR
               when other
                   add 1 to WS-Miss-Class
           end-evaluate.

           evaluate School-Code
               when '1'
                   add 1 to WS-CNT-A3-Bus
               when '2'
                   add 1 to WS-CNT-A3-Lan
               when '3'
                   add 1 to WS-CNT-A3-ENG
               when other
                   add 1 to WS-Miss-School
           end-evaluate.

       300-Module-RPT-Setup.
           move WS-TOT-Stud to Num-Stud.
           write Summary-record from WS-Blank.
           write Summary-record from WS-Title1.
           write Summary-record from WS-Blank.
           write Summary-record from WS-Title2.
           write Summary-record from WS-Blank.

       310-Module-RPTA.
           set LT20 to true.
           Move WS-CNT-Stud-U2gpa to RPTA-Counter.
           compute RPTA-Percentage = (WS-CNT-Stud-U2gpa / WS-TOT-Stud)
             * 100.
           write Summary-record from Rpt-Line-A.

           set 2to3 to true.
           Move WS-CNT-Stud-2-3gpa to RPTA-Counter.
           compute RPTA-Percentage = (WS-CNT-Stud-2-3gpa / WS-TOT-Stud)
             * 100.
           write Summary-record from Rpt-Line-A.

           set GT30 to true.
           Move WS-CNT-Stud-A3gpa to RPTA-Counter.
           compute RPTA-Percentage = (WS-CNT-Stud-A3gpa / WS-TOT-Stud)
             * 100.
           write Summary-record from Rpt-Line-A.





       end program Chapter8.
