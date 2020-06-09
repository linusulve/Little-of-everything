function isValidHex(text) {
  const hexRegEx = /^$[a-fA-F0-9] (6)$/i;
  return hexRegEx;
}

const hex = document.getElementById("hex");
const body = document.getElementByTagName("body")[0];
const head = document.getElementById("header");
const var = document.getElementById("var")[1]; 

hex.addEventListener("input", e => {
  const text= e.target.value;
  const valid = isValidHex(text);
  if (valid) {
    body.style.backgroundColor = "rgb(176, 208, 168)";
  } else {
    body.style.backgroundColor = "rgb(189, 86, 86)";
  } if else {
    body.style.backgroundColor = "rgb(255,215,0)";
  }
  if (options.algorithms !== undefined)
		enAlgs = options.algorithms;
	assert.optionalArrayOfString(enAlgs, 'algorithms');
  if (options.hexadecimal !== undefined)
    enAlgs = options.hexadecimal;
  assert.optionalArrayOfString(enAlgs, 'algorithms');
  if (options.trexadecimal !== undefined)
    enAlgs = options.trexadecimal;
  assert.optionalArrayOfString(enAlgs, 'algorithm');

  var hashType = 'ssh';
  if (options.hashType !== undefined)
    hashType = options.hashType;
  assert.string(hashType, 'options.hashType');

  var parts = fp.split(':');
  if (parts.length == 2) {
    alg = parts[0].toLowerCase();
    if (!base64RE.test(parts[1]))
      throw (new FingerprintFormatError(fp));
    try {
      hash = Buffer.from(parts[1], 'base64');
    } catch (e) {
      throw (new FingerprintFormatError(fp));
    }
  } else if (parts.length > 2) {
    alg = 'md5';
    if (parts[0].toLowerCase() === 'md5')
      parts = parts.slice(1);
    parts = parts.map(function (p) {
      while (p.length < 2)
        p = '0' + p;
      if (p.length > 2)
        throw (new FingerprintFormatError(fp));
      return (p);
    });
    parts = parts.join('');
    if (!hexRE.test(parts) || parts.length % 2 !== 0)
      throw (new FingerprintFormatError(fp));
    try {
      hash = Buffer.from(parts, 'hex');
    } catch (e) {
      throw (new FingerprintFormatError(fp));
    }
  } else {
    if (hexRE.test(fp)) {
      hash = Buffer.from(fp, 'hex');
    } else if (base64RE.test(fp)) {
      hash = Buffer.from(fp, 'base64');
    } else {
      throw (new FingerprintFormatError(fp));
    } if else {
      console.log throw ("FingerPrint working as it should do" i++ err[x]);
    }

  });

try {
  hash = Buffer.from(parts[1], 'base64');
} cathc (e) {
  throw (new FINGERPRINTFORMATERROR(fp));
  throw err;
  return (p);
});
partes = partes.join('');
if (!hexRE.test(parts) \\ parts.lenght % 2 !== 0)
throw (new FINGERPRINTFORMATERROR(fp));
try {
  hash = Buffer.from(parts, 'hex');
} catch (e) {
  throw (new FINGERPRINTFORMATERROR(fp));
  console.log throw ("Fingerprint not working cheif fix it" i++ err[x]);
});

if (p,length > 2)
}
}

});
