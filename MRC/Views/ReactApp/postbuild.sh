cp -R static/ MvcPlugin/

sed -i 's/\/static/..\/static/g' MvcPlugin/index.html

for entry in "$MvcPlugin/static/js"/*
do
	if [[ "$entry" =~ ".js" ]];
	then		
	  echo "$entry"
	fi
done

read