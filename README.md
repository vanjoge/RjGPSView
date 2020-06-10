# RjGPSView

一个简单的GPS位置展示

用于RG-MTFI-M520(ALIF)

设备通过shell脚本上报GPS信息，服务端展示定位位置


## 设备端
* 把rpgps.sh 放入 /root 目录

* 修改rpgps.sh中 gpsserver地址为你的服务器地址 用vi或上传前修改均可

* 给脚本赋执行权限

`chmod +x /root/rpgps.sh`


* 执行 ` crontab -e `

添加一行

` */1 * * * * /root/rpgps.sh `



按:wq 保存退出

 
