# 介绍
C# winForm利用AForge库实现对摄像头的调用、拍摄和保存
C# winForm USES AForge library to call, shoot and save the camera

本人2018年大二时开始学习C#，至今仍甚是喜爱这门语言。下面这些小项目记录了我在学习的过程中的一些收获及成果，我在这里把它们分享出来，也为互联网资源贡献自己的一份非常非常渺小的力量，希望能够帮助到有需要的朋友。

我的学习的离不开Github、CSDN等周多社区里的互联网前辈们的分享以及帮助，致敬！

# Camera_001
1. 实现功能

   通过winForm利用AForge库实现对摄像头的调用、拍摄和保存

2. 涉及技术

   - 引用第三方库
   - Aforge的方法、属性
   - 对磁盘的读写文件

3. 设计思路

   在窗体Load事件中检测PC设备中所有的摄像头设备，并利用FilterInfoCollection类对象获取设备集合。

   在comboBox控件change事件中完成对所选择的摄像头的调用。保存时利用Bitmap类获取图片，保存到项目所在目录。

4. 扩展思路

   可以扩展为木马程序：利用邮件，把拍摄的图片发送到指定的邮箱地址。等等吧随意发挥哈哈哈哈。
