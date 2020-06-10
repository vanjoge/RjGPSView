#! /bin/bash

gpsserver="http://sgj.budeng.win:55088"

_sendinfo=$(cat /tmp/gps)
_id=$(cat /tmp/sn)
_pdata=`echo -e "sn: ${_id}\n${_sendinfo}"`

#_sendinfo=$(echo ${_sendinfo//\"/\'})
 

curl --request POST \
  --url $gpsserver/Home/RpGps \
  --form data="$_pdata"
