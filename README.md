## 团队介绍

本项目由上海财经大学4人团队协作完成：

| 角色 | 姓名 | GitHub |
|------|------|--------|
| 项目组长 | Amelia | [@AmeliaHistory](https://github.com/AmeliaHistory) |
| 前端开发 | yoooooo-2711 | [@yoooooo-2711](https://github.com/yoooooo-2711) |
| 后端开发 | Fang-blkbns | [@Fang-blkbns](https://github.com/Fang-blkbns) |
| 文档/测试 | Moolady | [@Moolady](https://github.com/Moolady) |

# SufeCares-SQL
一、开发工具与语言 
    本项目采用Visual Studio作为集成开发环境，使用VB.NET语言进行编码。Visual Studio提供了可视化的窗体设计器；VB.NET则基于.NET Framework框架，支持事件驱动编程。 
二、数据库环境
    数据库管理系统（DBMS），使用Microsoft SQL Server（实例名2E79\MSSQLSERVER1），创建名为sufe的数据库，存储菜品、食堂、用户等数据。 
三、关键技术组件 
    1.数据访问：ADO.NET（SqlConnection/SqlCommand/SqlDataAdapter） 
    2.数据绑定：DataSet/DataTable与DataGridView联动 
    3.图形处理：System.Drawing命名空间（图片加载自适应显示）
# 🍽️ SufeCares-SQL 校园美食推荐系统

<div align="center">
  <img src="WindowsApp7/WindowsApp7/Resources/logo与背景.png" alt="项目Logo" width="200"/>
  <p><em>上财美食，一查便知</em></p>
</div>

---

## 📋 项目简介

**SufeCares-SQL** 是一款基于 **SQL Server + VB.NET** 开发的校园美食信息查询与推荐系统，由上海财经大学4人团队协作完成。本项目旨在为上财师生提供便捷的食堂信息查询、菜品浏览与推荐服务，解决“今天吃什么”的日常难题。

## 👥 团队介绍

本项目由上海财经大学4人团队历时2个月协作完成，分工明确，各司其职：

|头像  |	姓名|	GitHub|	主要负责|
|👩‍💻|	Amelia_History|	[@AmeliaHistory](https://github.com/AmeliaHistory)	|管理员界面、推荐/排行榜界面；项目意义撰写、图标背景设计、ER图绘制、页面美化|
|👩‍🔬|	yoooooo-2711|[@yv5s5hkpr2-design](https://github.com/yoooooo-2711)|今天吃什么页面、菜品详情页面、随机生成菜品页面、评论页面、map页面；项目不足和经验撰写|
|👩‍💻|	Fang-blkbns	|[@Fang-blkbns](https://github.com/Fang-blkbns)|数据库所有内容：建表、触发器、视图、存储过程；数据注入|
|🧑‍🚀	|Moolady|[@Moolady](https://github.com/Moolady) |	登录/注册/密码模块、个人中心、校味互鉴、主页面；系统格式统一、美化；PPT及报告相关部分|

> 💡 四位成员均为一作贡献，共同完成了这个项目的需求分析、设计、编码、测试全流程。项目获课程设计90+高分，被用作学弟妹学习参考。

---

## 🛠️ 技术栈

### 开发环境
| 组件 | 技术选型 | 说明 |
|------|----------|------|
| **集成开发环境** | Visual Studio | 提供可视化窗体设计器，支持拖拽式界面开发 |
| **编程语言** | VB.NET | 基于.NET Framework框架，支持事件驱动编程 |
| **版本控制** | Git + GitHub | 四人团队协作，代码开源 |

### 数据库
| 组件 | 技术选型 | 说明 |
|------|----------|------|
| **数据库管理系统** | Microsoft SQL Server | 实例名：`2E79\MSSQLSERVER1` |
| **数据库名** | `sufe` | 存储菜品、食堂、用户等核心数据 |
| **数据量** | 6张核心表 + 100+条测试数据 | 确保系统演示流畅 |

### 关键技术组件
| 技术组件 | 用途 | 实现细节 |
|----------|------|----------|
| **ADO.NET** | 数据访问 | SqlConnection建立连接，SqlCommand执行SQL，SqlDataAdapter填充数据集 |
| **DataSet / DataTable** | 数据绑定 | 与DataGridView联动，实现数据展示与更新 |
| **System.Drawing** | 图形处理 | 图片加载、缩放、自适应显示，提升用户体验 |
| **事件驱动编程** | 交互逻辑 | 按钮点击、窗体加载等事件响应 |

---

## 📁 项目结构
SufeCares-SQL/
├── 📂 WindowsApp7/ # 主项目文件夹
│ ├── 📂 .vs/ # Visual Studio 配置（已忽略）
│ ├── 📂 WindowsApp7/ # 源代码
│ │ ├── 📂 My Project/ # 项目配置（应用程序设置、资源、程序集信息）
│ │ ├── 📂 Resources/ # 图片资源（logo、菜品图片等）
│ │ ├── 📂 bin/ # 编译输出（已忽略）
│ │ ├── 📂 obj/ # 临时文件（已忽略）
│ │ ├── 📄 *.vb # 窗体代码文件（登录、主界面、菜品详情等）
│ │ ├── 📄 *.resx # 窗体资源文件
│ │ ├── 📄 WindowsApp7.vbproj # 项目文件
│ │ └── 📄 WindowsApp7.sln # 解决方案文件
│ └── 📄 
├── 📂 Database/ # 数据库脚本
│ ├── 📄 CreateTables.sql # 建表语句（6张核心表）
│ └── 📄 InsertData.sql # 测试数据插入（100+条）
├── 📄 scriptfinal.sql # 完整数据库脚本（建表+数据）
├── 📄 美食查看信息推荐SufeCares-介绍.pdf # 项目介绍文档
├── 📄 美食查看信息推荐SufeCares-报告.docx # 项目详细报告
├── 📄 README.md # 本文件
├── 📄 .gitignore # Git忽略配置
└── 📄 LICENSE # MIT开源许可证
