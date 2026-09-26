#AccountID				AccountNo	Email		Password	NickName	time
#00b8c734-79bd-48e7-ad1b-08f4d9fe00d2	2004	4b77c6f@outlook.com	Vk!dcITd	孤独的鳴人粉絲	2022-03-07 04:44:00.0000000 +00:00
#2cbc1ae5-a552-4320-bd00-28fef927aa56	2008	y3a556vynw@gmail.com	hzs0909@apps.ntpc.edu.tw胡宗劭	2020-08-03 21:05:00.0000000 +00:00
#0018bc99-cff5-492f-bcc4-75b624202a53	2001	jqsydy@hotmail.com	#Hwl8leaX%2	神秘的少年007	2021-10-30 20:06:00.0000000 +00:00
#01216222-082c-4608-9d23-79eeed0d3aed	2005	c2izdby@qq.com	iXDxh&NA9MM	热血的键盘侠	2022-04-29 16:34:00.0000000 +00:00
#00629376-9e24-45e3-9610-a4f42e727b82	2003	osmcw2@gmail.com	@vBMX@FYF3	喜歡佐助的猫咪	2020-04-24 00:09:00.0000000 +00:00
#0134a793-afc6-4c96-8f8f-cba3f3d9cfe2	2006	rk0vh8ef@163.com	e*6CFAqoQ	cosplay的小姐	2020-09-07 20:37:00.0000000 +00:00
#019561e6-fdb5-4aa2-94ec-d0fbd03f3a50	2007	rcsguzemp@gmail.com	JT!UucT4	霸气的老板	2022-07-26 03:27:00.0000000 +00:00
#003202ad-4578-4d60-85b1-de0b9e2c7f9a	2002	pkd3iqh@outlook.com	ZCY7zvrV^RV	愛看火影的先生	2020-07-27 10:17:00.0000000 +00:00
#上圖為遊戲帳號，亦可直接Load Game


# 忍者新世代：終極忍界大戰 (Naruto Ultimate Ninja World) 🍃

> **聲明**：本專案為個人學習與技術研究用途之 **非商業粉絲自製作品**。

---

## 📌 項目簡介 (Project Introduction)

本專案是一款基於 **C# Windows Forms (WinForms)** 開發的火影忍者主題粉絲自製遊戲。玩家可以在遊戲中體驗經典的忍界抽卡系統、收集並管理專屬忍者陣容，以及進行即時的戰力比拼對決。

### ✨ 核心特色
* **招募/抽卡系統 (Gacha System)**：支援單抽與十連抽，具備動態卡牌展示動畫與抽卡卡池數據庫連動。
* **忍者陣容管理 (Role Management)**：自動記錄玩家已解鎖的忍者，重複抽到卡片將轉化為角色碎片。
* **忍界對決 (Battle System)**：靈活的出陣編隊介面，動態匹配對手並比拼忍者綜合戰力 (`Total`) 決定勝負。
* **沉浸式 UI**：完美融入 WinForms 深色模式標題列與日式卡牌風格外框美化。

---

## 💻 運行環境要求 (Environment Requirements)

在編譯或執行本專案前，請確保你的開發環境滿足以下條件：

* **作業系統**：Windows 10 / Windows 11 (支援深色模式標題列 API)
* **.NET 框架版本**：`.NET Framework 4.7.2` 或更高版本 (或 `.NET 6.0 / 8.0 Windows Desktop Runtime`)
* **開發工具**：Visual Studio 2019 / 2022 (需安裝 *.NET 桌面開發* 工作負載)
* **資料庫環境**：SQL Server / LocalDB (搭配 Entity Framework 6 進行 ORM 存取)

---

## 🛠️ 安裝與執行說明 (Setup & Installation)

1. **複製專案 (Clone Repository)**
   ```bash
   git clone [https://github.com/SkyWu623/Naruto_UltimateNinjaWorld.git](https://github.com/SkyWu623/-_-)

## 資料庫(database)
當其他人（或你在其他電腦）複製（Clone）這個 GitHub 專案後，可以在 SSMS（SQL Server Management Studio）中透過以下方式選取這個 .bak 檔進行還原：
* **在 SSMS 的 Databases 上點右鍵，選擇 Restore Database...

* **將 Source 改為 Device，點擊右側 ... 按鈕選取專案資料夾中的 .bak 檔案。

* **點擊 OK 即可將資料庫還原回本地端。
