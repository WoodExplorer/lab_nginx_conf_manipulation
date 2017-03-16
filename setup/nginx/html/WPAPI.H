/*
* Copyright (c) 2009,华中科技大学计算机网络应用研究室
* All rights reserved.
*
* 文件名称：WPAPI.h
* 文件标识：见配置管理计划书
* 摘要：简要描述本文件的内容
*
* 当前版本：1.1
* 作者：彭在广
* 完成日期：2009年9月12日
*/

#ifndef WPAPI_H
#define WPAPI_H

//形成指定图片绝对路径
BOOL MakePicPathByNo(CString &szPath,INT No);

//排除字串
CString SubStingExcluding(CString str, CString substr);

//更新最后访问时间
VOID UpDateLastAccessTime(LPPER_HANDLE_DATA PerHandleData);

//从磁盘上读取试卷图片
DWORD ReadPictureFromDisk(PPAPERREC pPaper);


#endif