const Mustache = require("mustache");
const fs = require("fs");

const MUSTACHE_MAIN_DIR = "./main.mustache";

(function main() {
  // Add the folders you want to read
  const foldersToRead = ["../hackerrank", "../leetcode"];
  // Add the files you want to exclude
  const excludedFiles = ["", "structures"];

  const data = [];
  let size = 1;
  
  foldersToRead.forEach((folder) => {
    const files = fs.readdirSync(folder);
    let id = 1;
    files.forEach((file) => {
      size++;
      const newFile = file.split(".")[0].replace(/[0-9]|_/g, "");
      if (excludedFiles.indexOf(newFile) === -1) {
        data.push({
          id: id++,
          question: newFile,
          source: folder.split("/")[1],
          url: "./" + folder.split("/")[1] + "/" + file
        });
      }
    });
  });

  let DATA = {
    size: size,
    files: data
  };

  fs.readFile(MUSTACHE_MAIN_DIR, (err, data) => {
    if (err) throw err;
    const output = Mustache.render(data.toString(), DATA);
    fs.writeFileSync("../README.md", output);
  });
})();
