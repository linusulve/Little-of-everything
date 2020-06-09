const http = require("http")
const fs = require("fs")
const path = require("path")
const uuidv1 = require("uuid/v1")

const downloadPage = (url="http://nodeprogram.com/%22) => {
    console.log("downloading", url)

    const fetchPage = (urlf,callback) => {
        http.get(urlf, (response) => {
            let buff = ""
            response.on("data",(chunk) =>{
                buff += chunk
            })

            response.on("end",(chunk) => {
                callback(null, buff)
            })
        }).on("error", (error) => {
            console.error("error:${error.message}")
            callback(error)
        })
    }
    const folderName = uuidv1()
    fs.mkdirSync(folderName)

    fetchPage(url, (error,data) => {
        if (error) return console.log(error)
        fs.writeFileSync(path.join(dirname,folderName,"url.txt"),url)
        fs.writeFileSync(path.join(dirname,folderName,"file.html"),data)
        console.log("download done, folder: ", folderName)
    })
}


downloadPage(process.argv[2])
