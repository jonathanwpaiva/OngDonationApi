const ongsByCityResponse = [
    {
      "id": "63755daf2b68952338fb7e81",
      "name": "ABET-ASSOCIACAO BRASILEIRA DE ESCLEROSE TUBEROSA",
      "cnpj": "05037061000147",
      "uf": "MG",
      "municipio": "BELO HORIZONTE",
      "natureza_juridica": "Associação Privada",
      "descricao_situacao_cadastral": "ATIVA"
    },
    {
      "id": "63755e172b68952338fb7e82",
      "name": "ABRIGO FREI OTTO",
      "cnpj": "22442156000165",
      "uf": "MG",
      "municipio": "BELO HORIZONTE",
      "natureza_juridica": "Associação Privada",
      "descricao_situacao_cadastral": "ATIVA"
    },
    {
      "id": "63755e412b68952338fb7e83",
      "name": "ABRIGO JESUS",
      "cnpj": "17220021000115",
      "uf": "MG",
      "municipio": "BELO HORIZONTE",
      "natureza_juridica": "Associação Privada",
      "descricao_situacao_cadastral": "ATIVA"
    }
  ]

  const run = (ongsByCityResponse) => getMenu(ongsByCityResponse)

  const getMenu = (ongsByCityResponse) => {
      const ongs = JSON.parse(ongsByCityResponse)
  
      const menu = ongs.map(index, ong => {
          const textMenu = `${index} - ${ong.name}`
  
          return textMenu
      })
  
      return menu
  }

  console.log(run(ongsByCityResponse))