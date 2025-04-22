```
cargo build --release --target wasm32-wasi
cargo build --release

cargo +nightly build -Zbuild-std --target wasm32-unknown-emscripten --release
```

https://godot-rust.github.io/book/toolchain/export-web.html?highlight=web#thread-support-godot-43-or-later
https://github.com/godot-rust/gdext/issues/1119#issuecomment-2814205576
