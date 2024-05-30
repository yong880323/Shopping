<h1>一開始先新增一個 ASP.NET CORE WEB MVC 專案</h1>

![0](https://github.com/yong880323/Shopping/assets/113868193/cc496ee3-3282-4ec5-b5c2-cdbbb385b630)
<h3>新增後並建立Github版控</h3>
<BR>

![1](https://github.com/yong880323/Shopping/assets/113868193/1d11e94b-235c-4fbc-9b87-cc5eb5bfa24d)
<h3>在_Layout中新增Vue3、防止二次點擊</h3>
<BR>

![2](https://github.com/yong880323/Shopping/assets/113868193/d2d035c8-c2cd-4cf4-8b11-55df94f19ecd)
<h3>在Models底下新增Shoporder類別並且加入我們資料庫所要用的欄位</h3>
<BR>

![3](https://github.com/yong880323/Shopping/assets/113868193/c4c985fb-a8e1-4557-9421-ee84e9cc3733)
<h3>在appsettings裡新增與資料庫連線字串(MSSQL)</h3>
<BR>

![4](https://github.com/yong880323/Shopping/assets/113868193/54717c28-a501-4910-8c61-d7e798eaa8f1)
<h3>在專案右鍵後點選管理NuGet套件，並加入圖上的套件</h3>
<BR>

![5](https://github.com/yong880323/Shopping/assets/113868193/e3643c8d-447d-46c6-a103-c0abfd7bee7c)
<h3>在專案右鍵新增Data資料夾，並加入ShopDbContext類別及程式碼</h3>
<BR>

![6](https://github.com/yong880323/Shopping/assets/113868193/515bc76e-7dbd-4b2f-9986-b35b718e5786)
<h3>會發現DbContext出現紅色提示，移動到程式點開燈泡點選using Microsoft.EntityFrameworkCore; 然後再加入程式碼</h3>
<BR>

![7](https://github.com/yong880323/Shopping/assets/113868193/7d52adc6-ca06-4caf-b53d-77b6eff0f651)
<h3>開啟porgram.cs，在builder.Services.AddControllersWithViews();下面新增程式碼</h3>
<BR>



![8](https://github.com/yong880323/Shopping/assets/113868193/1b4765ec-34c9-45cc-8107-ab4668f0c286)
<h3>回到ShopDbContext 新增Shoporder的程式碼和要新增的測試資料程式碼</h3>
<BR>

![9](https://github.com/yong880323/Shopping/assets/113868193/4a55523c-a887-4eb5-86f2-4a61fdb91c45)
<h3>開啟套件管理器主控台，輸入add-migration AddShoppingTableToDb跟update-database兩個指令，會看到新增一個資料夾跟兩個檔案</h3>
<BR>

![10](https://github.com/yong880323/Shopping/assets/113868193/61a2316f-29f7-41e5-b002-770b231f4457)
<h3>開啟資料庫也會看到Shoporder這個table並且能還有我們在程式輸入的測試資料</h3>
<BR>

![11](https://github.com/yong880323/Shopping/assets/113868193/b29ade12-bcdb-4588-ae2e-e3e8ea7bae63)
<h3>在Controller新增ShoporderController控制器 然後加入以下程式碼 </h3>
<BR>

![12](https://github.com/yong880323/Shopping/assets/113868193/c4465bac-d698-43db-a0ad-35e25abdf095)
<h3>在index按右鍵的新增檢視 然後加入透過問AI的方式得到的前端程式碼畫面 </h3>
<BR>

![13](https://github.com/yong880323/Shopping/assets/113868193/00f41881-ef76-485f-aba2-1fbbef3ad3a7)
<h3>在_Layout中新增以下程式碼方便我們在上方的導覽列點選 </h3>
<BR>

![14](https://github.com/yong880323/Shopping/assets/113868193/457af50a-126b-41df-8c4f-0d13de15d086)
<h3>執行程式碼後點選上方的Shoporder呈現畫面如下 </h3>
<BR>

![15](https://github.com/yong880323/Shopping/assets/113868193/c599a349-7520-4b8c-9d94-713cafdb499f)
<h3>再來做Confirm的功能，到ShoporderController，新增以下程式碼，透過非同步方式修改多筆資料  </h3>
<BR>

![16](https://github.com/yong880323/Shopping/assets/113868193/a44a1101-a61a-443a-97ca-c451a6f11d7f)
<h3>回到前端index裡面，在form底下新增以下程式碼   </h3>
<BR>

![17](https://github.com/yong880323/Shopping/assets/113868193/820dcb95-757f-4972-a939-18f82a55473b)
<h3>執行程式碼後點選上方的Shoporder勾選第2、4筆，按下Confirm 成功立即修改狀態</h3>
<BR>

![18](https://github.com/yong880323/Shopping/assets/113868193/96a3c239-b047-4a38-a620-6113c4f2226d)
<h3>再來做顯示狀態的名稱 在Models資料夾底下新增我們的Param的類別</h3>
<BR>

![19](https://github.com/yong880323/Shopping/assets/113868193/057b793c-3bab-4eec-990b-62256b252ecd)
<h3>到ShopDbContext 新增Param的程式碼和要新增的測試資料程式碼</h3>
<BR>

![20](https://github.com/yong880323/Shopping/assets/113868193/ef61f11c-ecbe-4458-b7ff-1a9b51abd98f)
<h3>一樣開啟套件管理器主控台，輸入add-migration AddParamTable跟update-database兩個指令，到資料庫就會看到Param的table和測試資料</h3>
<BR>

![21](https://github.com/yong880323/Shopping/assets/113868193/8f4d1df0-b080-437b-a314-4b907e23088c)
<h3>回到ShoporderController，修改index裡面的程式碼  </h3>
<BR>

![22](https://github.com/yong880323/Shopping/assets/113868193/8a54761c-48c4-4d3c-82e2-904418c9219c)
<h3>回到前端index裡，修改tbody裡面的程式碼  </h3>
<BR>

![23](https://github.com/yong880323/Shopping/assets/113868193/5c4b04c8-1a12-4076-b86c-1acd20e8ab38)
<h3>執行程式碼後點選上方的Shoporder 就會看到名稱呈現出來</h3>
<BR>

![24](https://github.com/yong880323/Shopping/assets/113868193/3ebad910-95d3-4953-95f4-12f5bcf891aa)
<h3>最後點選明細的功能 我們回到ShoporderController 新增Details的程式碼</h3>
<BR>

![25](https://github.com/yong880323/Shopping/assets/113868193/e9a927c2-49a2-4fb2-9552-4fb0b3a3b9fa)
<h3>在Details右鍵新增空白檢視後，加入以下程式碼</h3>
<BR>

![27](https://github.com/yong880323/Shopping/assets/113868193/e321ee30-8de0-4170-9ff6-367dcdc65ad6)
<h3>回到前端index裡，修改td裡面的OrderItem程式碼</h3>
<BR>

![26](https://github.com/yong880323/Shopping/assets/113868193/cada54fb-f333-48c5-b4d5-b07f3b402f95)
<h3>執行程式碼後點選上方的Shoporder，會看到Order Item裡面的資料可以點選</h3>
<BR>

![28](https://github.com/yong880323/Shopping/assets/113868193/00e14397-6124-484f-a4a4-2b78e05d9dbc)
<h3>點選後就會帶到明細裡面</h3>
<BR>

![29](https://github.com/yong880323/Shopping/assets/113868193/002ab562-67ca-4d41-85c8-6679af339242)

