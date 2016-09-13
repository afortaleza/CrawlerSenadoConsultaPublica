# CrawlerSenadoConsultaPublica
Crawler de consultas públicas do senado

Como eu estou gerando o gráfico em
https://live.amcharts.com/jliZG

* Pego os três primeiros campos e separo em um arquivo
* Uso https://shancarter.github.io/mr-data-converter/ para converter para JSON
* Uso https://live.amcharts.com para gerar o gráfico a partir da fonte

Estou vendo se posso gerar o gráfico dinamicamente (por enquanto estou carregando o JSON manualmente)

===

Este é um crawler simples que consulta o site de Consultas Públicas do senado por votos a favor ou contra um projeto e imprime em um arquivo texto que pode ser importado para o excel.

Os campos, separados por tab, são os seguintes
* 1- Data\Hora do computador rodando o programa
* 2 - Votos a favor
* 3 - Votos contra
* 4 - Texto de data/hora do site do senado
* 5 - Data/hora do site do senado formatada

Um exemplo de output é o seguinte
```
Pressione qualquer tecla para parar a leitura...
Escrevendo 2016-09-12T18:37:42  14.162  24.808  Votos apurados até 12/09/2016 18:37:24. 12/09/2016 18:37:24
Escrevendo 2016-09-12T18:38:42  14.183  24.848  Votos apurados até 12/09/2016 18:38:25. 12/09/2016 18:38:25
Escrevendo 2016-09-12T18:39:42  14.201  24.900  Votos apurados até 12/09/2016 18:39:25. 12/09/2016 18:39:25
Escrevendo 2016-09-12T18:40:42  14.223  24.941  Votos apurados até 12/09/2016 18:40:26. 12/09/2016 18:40:26
Escrevendo 2016-09-12T18:41:42  14.241  24.986  Votos apurados até 12/09/2016 18:41:27. 12/09/2016 18:41:27
Escrevendo 2016-09-12T18:42:42  14.266  25.032  Votos apurados até 12/09/2016 18:42:27. 12/09/2016 18:42:27
Escrevendo 2016-09-12T18:43:42  14.295  25.080  Votos apurados até 12/09/2016 18:43:28. 12/09/2016 18:43:28
Escrevendo 2016-09-12T18:44:42  14.309  25.130  Votos apurados até 12/09/2016 18:44:29. 12/09/2016 18:44:29
Escrevendo 2016-09-12T18:45:42  14.329  25.176  Votos apurados até 12/09/2016 18:45:29. 12/09/2016 18:45:29
Escrevendo 2016-09-12T18:46:42  14.352  25.221  Votos apurados até 12/09/2016 18:46:30. 12/09/2016 18:46:30
Escrevendo 2016-09-12T18:47:42  14.371  25.254  Votos apurados até 12/09/2016 18:47:30. 12/09/2016 18:47:30
Escrevendo 2016-09-12T18:48:42  14.388  25.304  Votos apurados até 12/09/2016 18:48:31. 12/09/2016 18:48:31
Escrevendo 2016-09-12T18:49:42  14.406  25.358  Votos apurados até 12/09/2016 18:49:32. 12/09/2016 18:49:32
Escrevendo 2016-09-12T18:50:42  14.424  25.403  Votos apurados até 12/09/2016 18:50:33. 12/09/2016 18:50:33
Escrevendo 2016-09-12T18:51:42  14.455  25.450  Votos apurados até 12/09/2016 18:51:33. 12/09/2016 18:51:33
Escrevendo 2016-09-12T18:52:42  14.471  25.490  Votos apurados até 12/09/2016 18:52:34. 12/09/2016 18:52:34
Escrevendo 2016-09-12T18:53:42  14.488  25.533  Votos apurados até 12/09/2016 18:53:35. 12/09/2016 18:53:35
```

Não tem nada parametrizado, o código está amarrado a uma pesquisa sobre aborto do senado (já foi provado que esta gente do senado está de sacanagem com as votações). Não tive tempo ainda de adicionar screenshots.

Anderson Fortaleza
