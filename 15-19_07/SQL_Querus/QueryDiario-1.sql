select
aluno,
Materia,

(([Nota1]+ [Nota2] + [Nota3] + [Nota4] + [Nota5] + [Nota6])/3) as 'Media',

iif((([Nota1]+ [Nota2] + [Nota3] + [Nota4] + [Nota5] + [Nota6])/3) >= 7, 'Aprovado', 'Reprovado') as 'Status'

from [Diario-1]
