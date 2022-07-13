#include &lt;stdio.h&gt;
#include &lt;string.h&gt;

int main(){
float temp;
char letter[26] =
{&#39;a&#39;,&#39;b&#39;,&#39;c&#39;,&#39;d&#39;,&#39;e&#39;,&#39;f&#39;,&#39;g&#39;,&#39;h&#39;,&#39;i&#39;,&#39;j&#39;,&#39;k&#39;,&#39;l&#39;,&#39;m&#39;,&#39;n&#39;,&#39;o&#39;,&#39;p&#39;,&#39;q&#39;,&#39;r
&#39;,&#39;s&#39;,&#39;t&#39;,&#39;u&#39;,&#39;v&#39;,&#39;w&#39;,&#39;x&#39;,&#39;y&#39;,&#39;z&#39;};
int code[4];
char word[4]=&quot;cvtt&quot;;

float mat[2][2] = {{2,5},{1,3}};
float det = mat[0][0]*mat[1][1] - mat[1][0]*mat[0][1];
printf(&quot;\ninitial matrix is:&quot;);
for(int i = 0; i &lt; 2; i++){

printf(&quot;\n&quot;);
for(int j = 0; j &lt; 2; j++){
printf(&quot;\t%2.f&quot;, mat[i][j]);
}
}
float reversedMatrix[2][2] = { {mat[1][1], (-1)*mat[0][1]},
{(-1)*mat[1][0], mat[0][0]} };

printf(&quot;\n\ndeterminant is %.f\n\n&quot;, det);
printf(&quot;\n\ndeterminant is %.f\n\n&quot;, det);
printf(&quot;reversed matrix is\n&quot;);
for (int i = 0; i &lt; 2; i++) {
for (int j = 0; j &lt; 2; j++) {
printf(&quot;\t%2.f &quot;, reversedMatrix[i][j]);
}
printf(&quot;\n&quot;);
}
for(int i = 0; i&lt;4; i++){
for(int j = 0; j&lt;26; j++){
if(letter[j]==word[i]){
code[i]=j;
}
}
}

for(int i = 0; i&lt;2; i++){
for(int j = 0; j&lt;2; j++){
float tmp=reversedMatrix[i][j]/det;
while(tmp != (int)tmp ){

tmp *= det;
tmp += 26;
tmp /= det;
}
while(tmp &lt; 0){
tmp += 26;
}
reversedMatrix[i][j]=tmp;
}
printf(&quot;\n&quot;);
}

for(int i = 0; i&lt;4; i+=2){
word[i] = letter[(int) ( reversedMatrix[0][0]*code[i] +
reversedMatrix[0][1]*code[i+1] ) % 26];
}
printf(&quot;\ndecrypted word is %s\n&quot;, word);
}
