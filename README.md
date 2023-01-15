# CsharpHw_Winform
## 目前做好的部分:
- hw01 helloworld
- hw02 LoanMain
- hw03 POS
- hw14 pictureviewer
- hw15 GuessNumber


## 目前待解議題:
### 1. (已解決)讓子表單(winform)可以跟著主表單大小變動:已解決參考this.splitContainer1.Panel2.Controls.Add(frm);
### 2. (想不出來)讓new一個新winform可以寫成function例如

          if (_hw06 == null || IsClosed("hw06_StudentGrade_List"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw06 = new hw06_StudentGrade_List();
                var frm = _hw06;
                frm.Name = "hw06_StudentGrade_List";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }

### 3. (已解決)不曉得為何我的winform一直轉圈圈好像在跑什麼?
Form的UseWaitCursor屬性設定為true，就強制cursor只能是waiting狀態。改成false解決。
### 4. (未解決)hw14要做介面主表單叫出的多個子表單，當主表單關閉，大量的子表單要一起關閉，想用介面ISubPanel實作但失敗QQ


